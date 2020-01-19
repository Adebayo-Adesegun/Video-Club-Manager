using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VideoClub
{
    public static class VideoDb
    {
        //The stored procedure for the select statement in the database selects a record
        //based on the customerID number or the combination of first-name and surname
        
    public static Customer SelectCustomer_by_ID(int CustomerID)
        {
            Customer customer = new Customer();
            SqlConnection connection = VideoConnection.GetConnection();
        SqlCommand selectCommand = new SqlCommand();
        selectCommand.Connection = connection;
        selectCommand.CommandText = "Select_Customer";
        selectCommand.CommandType = CommandType.StoredProcedure;
        selectCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
        selectCommand.Parameters.AddWithValue("@FirstName", DBNull.Value);
        selectCommand.Parameters.AddWithValue("@Surname", DBNull.Value);
        try
        {
            connection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
            if(reader.Read())
            {
                customer.CustomerID = (int)reader["CustomerID"];
                customer.Firstname = reader["FirstName"].ToString();
                customer.Middlename = reader["MiddleName"].ToString();
                customer.Surname = reader["Surname"].ToString();
                customer.Dateofbirth = reader["DateOFBirth"].ToString();
                customer.Houseaddress1 = reader["HouseAddress1"].ToString();
                customer.Houseaddress2 = reader["HouseAddress2"].ToString();
                customer.PhoneNumber1 = reader["PhoneNumber1"].ToString();
                customer.PhoneNumber2 = reader["PhoneNumber2"].ToString();

            }
            else
            {
                customer = null;
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

        return customer;
        
        }

        /// <summary>
        /// select method for retrieving record from database using the firstname and lastname as the 
        /// search query
        /// </summary>
        /// <param name="CustomerID"></param>
        /// <returns></returns>
    public static Customer SelectCustomer_by_Fname_Sname(string Firstname,string Surname)
    {
        Customer customer = new Customer();
        SqlConnection connection = VideoConnection.GetConnection();
        SqlCommand selectCommand = new SqlCommand();
        selectCommand.Connection = connection;
        selectCommand.CommandText = "Select_Customer";
        selectCommand.CommandType = CommandType.StoredProcedure;
        selectCommand.Parameters.AddWithValue("@CustomerID", DBNull.Value);
        selectCommand.Parameters.AddWithValue("@FirstName", Firstname);
        selectCommand.Parameters.AddWithValue("@Surname", Surname);
        try
        {
            connection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
            if (reader.Read())
            {
                customer.CustomerID = (int)reader["CustomerID"];
                customer.Firstname = reader["FirstName"].ToString();
                customer.Middlename = reader["MiddleName"].ToString();
                customer.Surname = reader["Surname"].ToString();
                customer.Dateofbirth = reader["DateOFBirth"].ToString();
                customer.Houseaddress1 = reader["HouseAddress1"].ToString();
                customer.Houseaddress2 = reader["HouseAddress2"].ToString();
                customer.PhoneNumber1 = reader["PhoneNumber1"].ToString();
                customer.PhoneNumber2 = reader["PhoneNumber2"].ToString();

            }
            else
            {
                customer = null;
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

        return customer;

    }

        public static string AddCustomer (Customer customer)
    {
        SqlConnection connection = VideoConnection.GetConnection();
        SqlCommand addCommand = new SqlCommand();
        addCommand.Connection = connection;
        addCommand.CommandType = CommandType.StoredProcedure;
        addCommand.CommandText = "Insert_Customer";
        addCommand.Parameters.AddWithValue("@FirstName", customer.Firstname);
        addCommand.Parameters.AddWithValue("@MiddleName", customer.Middlename);
        addCommand.Parameters.AddWithValue("@Surname", customer.Surname);
        addCommand.Parameters.AddWithValue("@DateOfBirth", customer.Dateofbirth);
        addCommand.Parameters.AddWithValue("@HouseAddress1", customer.Houseaddress1);
        if (customer.Houseaddress2 == "")
            addCommand.Parameters.AddWithValue("@HouseAddress2", DBNull.Value);
        else
            addCommand.Parameters.AddWithValue("@HouseAddress2", customer.Houseaddress2);
        addCommand.Parameters.AddWithValue("@PhoneNumber1", customer.PhoneNumber1);
        if (customer.PhoneNumber2 == "")
            addCommand.Parameters.AddWithValue("@PhoneNumber2", DBNull.Value);
        else
            addCommand.Parameters.AddWithValue("@PhoneNumber2", customer.Houseaddress2);
            try
            {
                connection.Open();
                const string message = "Customer has been successfully committed to database";
                addCommand.ExecuteNonQuery();
                return message;
               
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch(DBConcurrencyException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close(); 
            }
        } 
        public static bool UpdateCustomer (Customer newCustomer, Customer oldCustomer)
        {
            SqlConnection connection = VideoConnection.GetConnection();
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.CommandText = "Update_Customer";
            updateCommand.CommandType = CommandType.StoredProcedure;
            updateCommand.Connection = connection;
            updateCommand.Parameters.AddWithValue("@OldFirstName", oldCustomer.Firstname);
            updateCommand.Parameters.AddWithValue("@OldMiddleName", oldCustomer.Middlename);
            updateCommand.Parameters.AddWithValue("@OldSurname", oldCustomer.Surname);
            updateCommand.Parameters.AddWithValue("@OlddateOfBirth", oldCustomer.Dateofbirth);
            updateCommand.Parameters.AddWithValue("@OldHouseAddress1", oldCustomer.Houseaddress1);
            if (oldCustomer.Houseaddress2 == "")
                updateCommand.Parameters.AddWithValue("@OldHouseAddress2", DBNull.Value);
            else
                updateCommand.Parameters.AddWithValue("@OldHouseAddress2", oldCustomer.Houseaddress2);
            updateCommand.Parameters.AddWithValue("@OldPhoneNumber1", oldCustomer.PhoneNumber1);
            if (oldCustomer.PhoneNumber2 == "")
                updateCommand.Parameters.AddWithValue("@OldPhoneNumber2", DBNull.Value);
            else
                updateCommand.Parameters.AddWithValue("@OldPhoneNumber2", oldCustomer.PhoneNumber2);
            updateCommand.Parameters.AddWithValue("@OldCustomerID", oldCustomer.CustomerID);

            updateCommand.Parameters.AddWithValue("@NewFirstName", newCustomer.Firstname);
            updateCommand.Parameters.AddWithValue("@NewMiddleName", newCustomer.Middlename);
            updateCommand.Parameters.AddWithValue("@NewSurname", newCustomer.Surname);
            updateCommand.Parameters.AddWithValue("@NewdateOfBirth", newCustomer.Dateofbirth);
            updateCommand.Parameters.AddWithValue("@NewHouseAddress1", newCustomer.Houseaddress1);
            if (newCustomer.Houseaddress2 == "")
                updateCommand.Parameters.AddWithValue("@NewHouseAddress2", DBNull.Value);
            else
                updateCommand.Parameters.AddWithValue("@NewHouseAddress2", newCustomer.Houseaddress2);
            updateCommand.Parameters.AddWithValue("@NewPhoneNumber1" , newCustomer.PhoneNumber1);
            if(newCustomer.PhoneNumber2 == "")
                updateCommand.Parameters.AddWithValue("@NewPhoneNumber2" , DBNull.Value);
            else
                updateCommand.Parameters.AddWithValue("@NewPhoneNumber2",newCustomer.PhoneNumber2);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if(count > 0)
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
        public static bool DeleteCustomer_by_ID (Customer customer)
        {
            SqlConnection connection = VideoConnection.GetConnection();
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.CommandText = "Delete_Customer";
            deleteCommand.CommandType = CommandType.StoredProcedure;
            deleteCommand.Connection = connection;
            deleteCommand.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
            deleteCommand.Parameters.AddWithValue("@FirstName", DBNull.Value);
            deleteCommand.Parameters.AddWithValue("@Surname", DBNull.Value);
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
            catch(DBConcurrencyException exception)
            {
                throw exception;
            }
            finally
            {
                connection.Close();
            }
        }


        //delete customer using the First_name and surname as parameters 
        //to the stored procedure

        public static bool DeleteCustomer_Fname_Sname(Customer customer)
        {
            SqlConnection connection = VideoConnection.GetConnection();
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.CommandText = "Delete_Customer";
            deleteCommand.CommandType = CommandType.StoredProcedure;
            deleteCommand.Connection = connection;
            deleteCommand.Parameters.AddWithValue("@FirstName", customer.Firstname);
            deleteCommand.Parameters.AddWithValue("@Surname", customer.Surname);
            deleteCommand.Parameters.AddWithValue("@CustomerID", DBNull.Value);

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



    }
}
