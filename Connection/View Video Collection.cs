using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VideoClub
{
    public partial class FrmView_Video_Collection : Form
    {
        Video video = new Video();
        
        public FrmView_Video_Collection()
        {
            InitializeComponent();
        }

        private void Display_video()
        {
            TxtArating.Text = Convert.ToString(video.Agerating);
            TxtMGenre.Text = Convert.ToString(video.Genre);
            TxtQLeft.Text = Convert.ToString(video.Quantity);
            TxtRyear.Text = Convert.ToString(video.Yearofrelease); 
        }
        private void View_Video_Collection_Load(object sender, EventArgs e)
        {
            LoadVideoCombobox();
        }

        public static List<Video> GetVideo()
        {
            List<Video> videos = new List<Video>();
            SqlConnection connection = VideoConnection.GetConnection();
            string selectstatement = "SELECT VideoName, VideoID " + "FROM Video " + "ORDER BY VideoName";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while(reader.Read())
                {
                    Video video = new Video();
                    video.Videoname = reader["VideoName"].ToString();
                   
                    videos.Add(video);
                }
                reader.Close();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return videos;

            
        }
        private void LoadVideoCombobox()
        {
            List<Video> videos = new List<Video>();
            try
            {
                videos = GetVideo();
                CboVideos.DataSource = videos;
                CboVideos.DisplayMember = "VideoName";
                CboVideos.ValueMember = "VideoName";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void display_imageData()
        {
            try
            {
                string value = CboVideos.Text;
                video = VideoDB.Select_by_Video_Name(value);
                Image image;
                if (video.ImageData != null)
                {
                    MemoryStream memstr = new MemoryStream(video.ImageData);
                    image = Bitmap.FromStream(memstr);
                    image = RezieImageClass.ResizeImage(image, 230, 191);
                    PicBVideoImage.Image = image;

                }
                else
                {
                    MessageBox.Show("No Image was entered for this movie", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("No Image was entered for this movie", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          
            
        }

       private void button1_Click(object sender, EventArgs e)
        {
            clear_Controls();
            string value = CboVideos.Text;
            video = VideoDB.Select_by_Video_Name(value);
            if (video != null)
            {
                display_imageData();
                Display_video();
            }
            else
                MessageBox.Show("The video does not exist", "Video Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
           
        }
        private void clear_Controls()
       {
           TxtArating.Text = "";
           TxtMGenre.Text = "";
           TxtQLeft.Text = "";
           TxtRyear.Text = "";
           PicBVideoImage.Image = null;
       }

       


    }
}
