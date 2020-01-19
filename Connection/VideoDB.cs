using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VideoClub
{
 public static class VideoDB
    {
     public static Video Select_by_Video_Name(string VideoName)
     {
         Video video = new Video();
         SqlConnection connection = VideoConnection.GetConnection();
         SqlCommand selectCommand = new SqlCommand();
         selectCommand.Connection = connection;
         selectCommand.CommandType = CommandType.StoredProcedure;
         selectCommand.CommandText = "Select_Video";
         selectCommand.Parameters.AddWithValue("@VideoName", VideoName);
         try
         {
             connection.Open();
             SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
             if (reader.Read())
             {
                 video.Videoname = reader["VideoName"].ToString();
                 video.Agerating = (int)reader["AgeRating"];
                 video.Yearofrelease = reader["YearOfRelease"].ToString();
                 video.Quantity = (int)reader["Quantity"];
                 video.Genre = reader["Genre"].ToString();
                 byte[] imgdata = (byte[])reader["Image"];
                 video.ImageData = imgdata;
                
             }
             else
             {
                 video = null;
             }
             reader.Close();
         }
         catch (SqlException ex)
         {
             throw ex;
         }

         finally
         {
             connection.Close();
         }
         return video;
     } 
     // method to select videos form the database by their name
     
     // method to select video row from database using the year of release as search criterion

     //public static Video Select_by_Video_YearOfRelease(DateTime releaseDate)
     //{
     //    Video video = new Video();
     //    SqlConnection connection = VideoConnection.GetConnection();
     //    SqlCommand selectCommand = new SqlCommand();
     //    selectCommand.Connection = connection;
     //    selectCommand.CommandType = CommandType.StoredProcedure;
     //    selectCommand.CommandText = "Select_Video";
     //    selectCommand.Parameters.AddWithValue("@VideoName", DBNull.Value );
     //    selectCommand.Parameters.AddWithValue("@YearOfrelease", releaseDate);
     //    selectCommand.Parameters.AddWithValue("@AgeRating", DBNull.Value);
     //    try
     //    {
     //        connection.Open();
     //        SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
     //        if (reader.Read())
     //        {
     //            video.Videoid = (int)reader["VideoID"];
     //            video.Videoname = reader["VideoName"].ToString();
     //            video.Yearofrelease = reader["YearOfrelease"].ToString();
     //            video.Agerating = (int)reader["AgeRating"];
     //            video.Quantity = (int)reader["Quantity"];
     //        }
     //        else
     //        {
     //            video = null;
     //        }
     //        reader.Close();
     //    }
     //    catch (SqlException ex)
     //    {
     //        throw ex;
     //    }
     //    catch (DBConcurrencyException ex)
     //    {
     //        throw ex;
     //    }

     //    finally
     //    {
     //        connection.Close();
     //    }
     //    return video;

     //}
     // method for select videos based on the age input query

    // public static Video Select_by_Video_Agerating(int AgeRating)
     //{
     //    Video video = new Video();
     //    SqlConnection connection = VideoConnection.GetConnection();
     //    SqlCommand selectCommand = new SqlCommand();
     //    selectCommand.Connection = connection;
     //    selectCommand.CommandType = CommandType.StoredProcedure;
     //    selectCommand.CommandText = "Select_Video";
     //    selectCommand.Parameters.AddWithValue("@VideoName", DBNull.Value);
     //    selectCommand.Parameters.AddWithValue("@YearOfrelease", DBNull.Value);
     //    selectCommand.Parameters.AddWithValue("@AgeRating", AgeRating);
     //    try
     //    {
     //        connection.Open();
     //        SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
     //        if (reader.Read())
     //        {
     //            video.Videoid = (int)reader["VideoID"];
     //            video.Videoname = reader["VideoName"].ToString();
     //            video.Yearofrelease = reader["YearOfrelease"].ToString();
     //            video.Agerating = (int)reader["AgeRating"];
     //            video.Quantity = (int)reader["Quantity"];
     //        }
     //        else
     //        {
     //            video = null;
     //        }
     //        reader.Close();
     //    }
     //    catch (SqlException ex)
     //    {
     //        throw ex;
     //    }
     //    catch (DBConcurrencyException ex)
     //    {
     //        throw ex;
     //    }

     //    finally
     //    {
     //        connection.Close();
     //    }
     //    return video;

     //}
     public static bool DeleteVideo(Video video)
     {
         SqlConnection connection = VideoConnection.GetConnection();
         SqlCommand deleteCommand = new SqlCommand();
         deleteCommand.CommandText = "Delete_Video";
         deleteCommand.CommandType = CommandType.StoredProcedure;
         deleteCommand.Connection = connection;
         deleteCommand.Parameters.AddWithValue("@VideoName", video.Videoname);
         deleteCommand.Parameters.AddWithValue("@yearOfRelease", video.Yearofrelease);
         try
         {
             connection.Open();
             int count = deleteCommand.ExecuteNonQuery();
             if (count > 0)
                 return true;
             else
                 return false;
         }
         catch (SqlException ex)
         {
             throw ex;
         }
         catch (DBConcurrencyException exception)
         {
             throw exception;
         }
         finally
         {
             connection.Close();
         }
     }

    

     public static bool UpdateVideo(Video newVideo, Video oldVideo)
     {
         SqlConnection connection = VideoConnection.GetConnection();
         SqlCommand updateCommand = new SqlCommand();
         updateCommand.CommandText = "Update_Video";
         updateCommand.CommandType = CommandType.StoredProcedure;
         updateCommand.Connection = connection;
         updateCommand.Parameters.AddWithValue("@VideoName", newVideo.Videoname);
         updateCommand.Parameters.AddWithValue("@YearOfRelease", newVideo.Yearofrelease);
         updateCommand.Parameters.AddWithValue("@AgeRating", newVideo.Agerating);
         updateCommand.Parameters.AddWithValue("@Quantity", newVideo.Quantity);

         updateCommand.Parameters.AddWithValue("@VideoName", oldVideo.Videoname);
         updateCommand.Parameters.AddWithValue("@YearOfRelease", oldVideo.Yearofrelease);
         updateCommand.Parameters.AddWithValue("@AgeRating", oldVideo.Agerating);
         updateCommand.Parameters.AddWithValue("@Quantity", oldVideo.Quantity);


        

         try
         {
             connection.Open();
             int count = updateCommand.ExecuteNonQuery();
             if (count > 0)
                 return true;
             else
                 return false;

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
    }
}
