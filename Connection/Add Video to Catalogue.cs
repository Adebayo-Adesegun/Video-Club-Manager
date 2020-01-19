using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace VideoClub
{
	public partial class FrmAdd_Video_to_Catalogue : Form
	{
		Video video = new Video();


		public FrmAdd_Video_to_Catalogue()
		{
			InitializeComponent();
		}

		private void PutVideo(Video video)
		{
			video.Videoname = TxtVideoName.Text;
			video.Yearofrelease = DtpYear.Value.ToString("dd/MM/yyyy"); ;
			video.Agerating = (int)Nudage.Value;
			video.Quantity = (int)nudQuantity.Value;
			video.Genre = (string) cboGenre.Text;

		}

		private bool IsValidData()
		{
			if (Validator.Ispresent(TxtVideoName) && Validator.Ispresent(TxtFilePath) &&
				Validator.IsWithinRange(Nudage) && Validator.IsWithinRange(nudQuantity))
			{
				if (nudQuantity.Value < 1)
					MessageBox.Show("Please enter a positive value", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				if (DtpYear.Value == DateTime.Now)
					MessageBox.Show("Please enter the correct date", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{ return false; }
			return true;

		}
		private void FrmAdd_Video_to_Catalogue_Load(object sender, EventArgs e)
		{

		}

		private void btnChooseF_Click(object sender, EventArgs e)
		{
			try
			{
				openFD.Title = "Choose Image File";
				openFD.InitialDirectory = "C:";
				openFD.Filter = "Jpeg|*.Jpg|Bitmap|*.bmp|Gif|*.gif";
				openFD.Multiselect = false;
				openFD.ShowDialog();
				if (openFD.ShowDialog() == DialogResult.OK)
				{
					// send picture file to resize method which returns resized picture to the picture box
					Bitmap photo = (Bitmap)Image.FromFile(openFD.FileName);

					PicBVideoImage.Image = RezieImageClass.ResizeImage(photo, 230, 191);
					TxtFilePath.Text = openFD.FileName;
					

				}


			}
			catch (BadImageFormatException ex)
			{
				MessageBox.Show(ex.Message.ToString(), ex.GetType().ToString());
			}




		}
		public static string AddVideo(Video video,byte[] imgdata)
		{
			SqlConnection connection = VideoConnection.GetConnection();
			SqlCommand addCommand = new SqlCommand();
			addCommand.Connection = connection;
			addCommand.CommandType = CommandType.StoredProcedure;
			addCommand.CommandText = "Insert_Video";
			addCommand.Parameters.AddWithValue("@VideoName", video.Videoname);
			addCommand.Parameters.AddWithValue("@YearOfRelease", video.Yearofrelease);
			addCommand.Parameters.AddWithValue("@AgeRating", video.Agerating);
			addCommand.Parameters.AddWithValue("@Quantity", video.Quantity);
			addCommand.Parameters.AddWithValue("@Genre", video.Genre);
			SqlParameter sqlparam = addCommand.Parameters.AddWithValue("@Image", imgdata);
			sqlparam.DbType = DbType.Binary;

			try
			{
				connection.Open();
				const string message = "Record has been successfully committed to database";
				int count;
				count = addCommand.ExecuteNonQuery();
				if (count > 0)
					return message;
				else
					return "The Record Was not committed to the database";

			}
			catch (SqlException ex)
			{
				throw ex;
			}
			catch (DBConcurrencyException ex)
			{
				throw ex;
			}
			finally
			{
				connection.Close();
			}
		}
	   
	 
	private void BtnSubmit_Click(object sender, EventArgs e)
		{
			if(IsValidData())
			{
				Video video = new Video();
				PutVideo(video);
			   
				try{
					byte[] imageData = null;
					FileInfo fileInfo = new FileInfo(TxtFilePath.Text);
					long imageFileLength = fileInfo.Length;
					FileStream fs = new FileStream(TxtFilePath.Text, FileMode.Open, FileAccess.Read);
					BinaryReader br = new BinaryReader(fs);
					imageData = br.ReadBytes((int)imageFileLength);
					string message = AddVideo(video,imageData);
					MessageBox.Show("Record has been successfully committed to database","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
					//Insert_ImageFile_into_Database_Table(TxtFilePath.Text);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message, ex.GetType().ToString());
				}
			   
			}
		}
	}
}
