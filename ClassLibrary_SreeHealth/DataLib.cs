using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_SreeHealth
{
    class DataLib
    {
        string Connection = "server=DESKTOP-679JJF8;database=Sree_Health;Integrated Security=true";
        #region LOAD
        public DataTable LoadData(string sp)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
        public DataTable LoadData_Email(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", plib.Email);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
        public DataTable LoadData_DoctorID(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DoctorID", plib.DoctorID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
        #endregion LOAD

        #region GET
        public int GetUserRole(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", plib.Email);
                    cmd.Parameters.Add("@UserRole", SqlDbType.Int);
                    cmd.Parameters["@UserRole"].Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    return (int)cmd.Parameters["@UserRole"].Value;
                }
            }
        }
        public string GetPatientID(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", plib.Email);
                    cmd.Parameters.Add("@PatientID", SqlDbType.NVarChar, 128);
                    cmd.Parameters["@PatientID"].Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    return (string)cmd.Parameters["@PatientID"].Value;
                }
            }
        }

        public int GetUserRole_UserID(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", plib.UserID);
                    cmd.Parameters.Add("@UserRole", SqlDbType.Int);
                    cmd.Parameters["@UserRole"].Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    return (int)cmd.Parameters["@UserRole"].Value;
                }
            }
        }
        public bool ValidateEmail(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", plib.Email);
                    cmd.Parameters.Add("@Output", SqlDbType.Bit);
                    cmd.Parameters["@Output"].Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    return (bool)cmd.Parameters["@Output"].Value;
                }
            }
        }

        #endregion GET

        #region INSERT
        public void Insert_T01(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Department", plib.Department);
                    cmd.Parameters.AddWithValue("@Status", plib.Status);
                    cmd.Parameters.AddWithValue("@UserID", plib.UserID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Insert_T02(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DepartmentID", plib.DepartmentID);
                    cmd.Parameters.AddWithValue("@Doctor", plib.Doctor);
                    cmd.Parameters.AddWithValue("@Qualification", plib.Qualification);
                    cmd.Parameters.AddWithValue("@Note", plib.Note);
                    cmd.Parameters.AddWithValue("@Email", plib.Email);
                    cmd.Parameters.AddWithValue("@Contact", plib.Contact);
                    cmd.Parameters.AddWithValue("@Address", plib.Address);
                    cmd.Parameters.AddWithValue("@Status", plib.Status);
                    cmd.Parameters.AddWithValue("@UserID", plib.UserID);
                    cmd.ExecuteNonQuery();
                }

            }
        }
        public void Insert_T03(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Patient", plib.Patient);
                    cmd.Parameters.AddWithValue("@Age", plib.Age);
                    cmd.Parameters.AddWithValue("@Gender", plib.Gender);
                    cmd.Parameters.AddWithValue("@Email", plib.Email);
                    cmd.Parameters.AddWithValue("@Contact", plib.Contact);
                    cmd.Parameters.AddWithValue("@Address", plib.Address);
                    cmd.Parameters.AddWithValue("@Note", plib.Note);
                    cmd.Parameters.AddWithValue("@Status", plib.Status);
                    cmd.Parameters.AddWithValue("@UserID", plib.UserID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Insert_T04(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@DepartmentID", plib.DepartmentID);
                    cmd.Parameters.AddWithValue("@DoctorID", plib.DoctorID);
                    cmd.Parameters.AddWithValue("@PatientID", plib.PatientID);
                    cmd.Parameters.AddWithValue("@Date", plib.Date);
                    cmd.Parameters.AddWithValue("@Note", plib.Note);
                    cmd.Parameters.AddWithValue("@Status", plib.Status);
                    cmd.Parameters.AddWithValue("@UserID", plib.UserID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Insert_T05(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AppointmentID", plib.AppointmentID);
                    cmd.Parameters.AddWithValue("@Prescription", plib.Prescription);
                    cmd.Parameters.AddWithValue("@Status", plib.Status);
                    cmd.Parameters.AddWithValue("@UserID", plib.UserID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion INSERT

    }
}
