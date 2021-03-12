using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Blogs
{
    public class PostSqlDao : IPostDao
    {
        private readonly string connectionString;

        public PostSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Post> GetAllPosts()
        {
            // Implement this method to pull in all posts from database

            List<Post> returnPosts = new List<Post>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT id, name, body, published, created FROM posts;", conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Post post = new Post()
                        {
                            Body = Convert.ToString(reader["body"]),
                            Created = Convert.ToDateTime(reader["created"]),
                            Id = Convert.ToInt64(reader["id"]),
                            IsPublished = Convert.ToBoolean(reader["published"]),
                            Name = Convert.ToString(reader["name"]),
                        };

                        returnPosts.Add(post); 
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return returnPosts;
        }

        public void Save(Post newPost)
        {
            // Implement this method to save post to database


            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO posts (name, body, published, created) VALUES(@name, @body, @published, @created); SELECT @@IDENTITY;", conn);
                    cmd.Parameters.AddWithValue("@name", newPost.Name);
                    cmd.Parameters.AddWithValue("@body", newPost.Body);
                    cmd.Parameters.AddWithValue("@published", newPost.IsPublished);
                    cmd.Parameters.AddWithValue("@created", newPost.Created);

                    newPost.Id = (int)(decimal)cmd.ExecuteScalar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}