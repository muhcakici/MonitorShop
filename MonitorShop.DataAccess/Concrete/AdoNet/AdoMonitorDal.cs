using Microsoft.Data.SqlClient;
using MonitorShop.DataAccess.Abstract;
using MonitorShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MonitorShop.DataAccess.Concrete.AdoNet
{
    public class AdoMonitorDal : IMonitorDal
    {
        public void Add(Monitor entity)
        {
            using (SqlCommand cmd = new SqlCommand("Insert Into Monitors (Model,Stock,UnitPrice) Values (@Model,@Stock, @UnitPrice)")) 
            {
                cmd.Parameters.AddWithValue("Model", entity.Model);
                cmd.Parameters.AddWithValue("Stock", entity.Stock);
                cmd.Parameters.AddWithValue("UnitPrice", entity.UnitPrice);
                VTYS.SqlExecuteNonQuery(cmd);  
            }
            Console.WriteLine("Monitor Added.");
        }
        public void Delete(Monitor entity)
        {
            using (SqlCommand cmd =
                new SqlCommand("Delete From Monitors where Id = @Id"))
            {
                cmd.Parameters.AddWithValue("Id", entity.Id);
                VTYS.SqlExecuteNonQuery(cmd);      
            }
            Console.WriteLine("Monitor Deleted.");
        }
        public Monitor Get(Expression<Func<Monitor, bool>> filter)
        {
            return null;
        }
        public List<Monitor> GetAll(Expression<Func<Monitor, bool>> filter = null)
        {
            var monitorList = new List<Monitor>();
            SqlCommand cmd = new SqlCommand("Select * from Monitors");
            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Monitor monitor = new Monitor
                {
                    Id = Convert.ToInt32(reader[0]),
                    Model = reader[1].ToString(),
                    Stock =Convert.ToInt32(reader[2]),
                    UnitPrice = Convert.ToDecimal(reader[3]),
                };

                monitorList.Add(monitor);
            }
            return monitorList;
        }
        public void Update(Monitor entity)
        {
            using (SqlCommand cmd =
               new SqlCommand("Update Monitors set Model = @Model, Stock = @Stock, UnitPrice = @UnitPrice Where Id = @Id"))
            {
                cmd.Parameters.AddWithValue("Id", entity.Id);
                cmd.Parameters.AddWithValue("Model", entity.Model);
                cmd.Parameters.AddWithValue("Stock", entity.Stock);
                cmd.Parameters.AddWithValue("UnitPrice", entity.UnitPrice);
                VTYS.SqlExecuteNonQuery(cmd);
            }
            Console.WriteLine("Monitor Updated.");
        }
    }
}
