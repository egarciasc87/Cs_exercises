using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;
using LibraryWebAPI.Models;

namespace LibraryWebAPI.Data
{
    public class AuthorData
    {
        public static bool Insert(Author author)
        {
            SqlConnection con = new 
                SqlConnection(Connection.connectionString);
            SqlCommand cmd = new SqlCommand("INSERT_AUTHOR_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@ID", author.Id);
            cmd.Parameters.Add("@FIRST_NAME", author.FirstName);
            cmd.Parameters.Add("@LAST_NAME", author.LastName);
            
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                con.Close();
                return false;
            }
        }

        public static bool Update(Author author)
        {
            SqlConnection con = new
                SqlConnection(Connection.connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE_AUTHOR_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", author.Id);
            cmd.Parameters.Add("@FIRST_NAME", author.FirstName);
            cmd.Parameters.Add("@LAST_NAME", author.LastName);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                con.Close();
                return false;
            }
        }

        public static bool Delete(int id)
        {
            SqlConnection con = new
                SqlConnection(Connection.connectionString);
            SqlCommand cmd = new SqlCommand("DELETE_AUTHOR_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                con.Close();
                return false;
            }
        }

        public static List<Author> Listar()
        {
            List<Author> list = new List<Author>();
            SqlConnection con = new
                SqlConnection(Connection.connectionString);
            SqlCommand cmd = new SqlCommand("LIST_AUTHOR_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                con.Open();
                var oDr = cmd.ExecuteReader();

                while (oDr.Read())
                {
                    list.Add(new Author()
                    {
                        Id = Convert.ToInt16(oDr["ID"].ToString()),
                        FirstName = oDr["FIRST_NAME"].ToString(),
                        LastName = oDr["laST_NAME"].ToString()
                    });
                }

                con.Close();
            }
            catch
            {
                con.Close();
            }

            return list;
        }

        public static Author Buscar(int id)
        {
            Author author;
            var list = Listar();
            author = list.FirstOrDefault(p => p.Id == id);

            return author;
        }
    }
}