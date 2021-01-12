﻿using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RentRepository
    {
        public List<User> GetAllUsers()
        {
            List<User> resultUser = new List<User>();
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Users";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    User u = new User();
                    u.UserID = sqlDataReader.GetInt32(0);
                    u.Name = sqlDataReader.GetString(1);
                    u.Surname = sqlDataReader.GetString(2);
                    u.Address = sqlDataReader.GetString(3);
                    u.Telephone = sqlDataReader.GetString(4);
                    u.Email = sqlDataReader.GetString(5);
                    u.Password = sqlDataReader.GetString(6);

                    resultUser.Add(u);
                }
            }
            return resultUser;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> resultProduct = new List<Product>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Product";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Product p = new Product();
                    p.ProductID = sqlDataReader.GetInt32(0);
                    p.Type = sqlDataReader.GetString(1);
                    p.ForAge = sqlDataReader.GetString(2);
                  
                    resultProduct.Add(p);
                }
            }
            return resultProduct;
        }

        public int InserUser(User u)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Users VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    u.Name, u.Surname, u.Address, u.Telephone, u.Email, u.Password);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int InserProduct(Product p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Product VALUES ('{0}','{1}')",
                    p.Type, p.ForAge);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int CheckUser(User u)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    "SELECT COUNT (*) FROM Users WHERE Email = " + u.Email + "AND Password = " + u.Password + "";

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int DeleteUser(User d)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                   string.Format("DELETE FROM Users WHERE Email = '{0}'", d.Email);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int UpdateUser(User up)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                   string.Format("UPDATE Users SET Address = '{0}', Telephone = '{1}', Email = '{2}', Password = '{3}' " +
                   "WHERE Name = '{4}' AND Surname = '{5}'", up.Address, up.Telephone, up.Email, up.Password, up.Name, up.Surname);

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
