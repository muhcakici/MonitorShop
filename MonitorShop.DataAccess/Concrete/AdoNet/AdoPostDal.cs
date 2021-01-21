using Microsoft.Data.SqlClient;
using MonitorShop.DataAccess.Abstract;
using MonitorShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MonitorShop.DataAccess.Concrete.AdoNet
{
    public class AdoPostDal : IPostDal
    {
        public void Add(Post entity)
        {
            using (SqlCommand cmd = new SqlCommand("Insert Into Posts (Title,Details) Values (@Title,@Details)"))
            {
                cmd.Parameters.AddWithValue("Title", entity.Title);
                cmd.Parameters.AddWithValue("Details", entity.Details);
                VTYS.SqlExecuteNonQuery(cmd);
            }
            Console.WriteLine("Post Added With AdoNet.");
        }

        public void Delete(Post entity)
        {
            using (SqlCommand cmd =
                new SqlCommand("Delete From Posts where Id = @Id"))
            {
                cmd.Parameters.AddWithValue("Id", entity.Id);
                VTYS.SqlExecuteNonQuery(cmd);
            }
            Console.WriteLine("Post Deleted With AdoNet.");
        }

        public Post Get(Expression<Func<Post, bool>> filter)
        {
            return null;
        }

        public List<Post> GetAll(Expression<Func<Post, bool>> filter = null)
        {
            var postList = new List<Post>();
            SqlCommand cmd = new SqlCommand("Select * from Posts");
            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Post post = new Post
                {
                    Id = Convert.ToInt32(reader[0]),
                    Title = reader[1].ToString(),
                    Details = reader[2].ToString()
                };

                postList.Add(post);
            }
            return postList;
        }

        public void Update(Post entity)
        {
            using (SqlCommand cmd =
               new SqlCommand("Update Posts set Title = @Title, Details = @Details Where Id = @Id"))
            {
                cmd.Parameters.AddWithValue("Id", entity.Id);
                cmd.Parameters.AddWithValue("Title", entity.Title);
                cmd.Parameters.AddWithValue("Details", entity.Details);
                VTYS.SqlExecuteNonQuery(cmd);
            }
            Console.WriteLine("Post Updated With AdoNet.");
        }
    }
}
