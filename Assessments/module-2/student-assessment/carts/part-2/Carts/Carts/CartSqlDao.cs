using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Carts
{
    public class CartSqlDao : ICartDao
    {
        private readonly string connectionString;

        public CartSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Cart> GetAllCarts()
        {
            // Implement this method to pull in all carts from database

            List<Cart> returnCarts = new List<Cart>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT id, username, cookie_value, created FROM carts;", conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Cart cart = new Cart()
                        {
                            CookieValue = Convert.ToString(reader["cookie_value"]),
                            Created = Convert.ToDateTime(reader["created"]),
                            Id = Convert.ToInt64(reader["id"]),
                            Username = Convert.ToString(reader["username"]),
                        };

                        returnCarts.Add(cart);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return returnCarts;
        }

        public void Save(Cart newCart)
        {
            // Implement this method to save cart to database

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO carts (username, cookie_value, created) VALUES (@username, @cookie_value, @created);SELECT @@IDENTITY;", conn);
                    cmd.Parameters.AddWithValue("@username", newCart.Username);
                    cmd.Parameters.AddWithValue("@cookie_value", newCart.CookieValue);
                    cmd.Parameters.AddWithValue("@created", newCart.Created);

                    newCart.Id = (int)(decimal)cmd.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}