using MonitorShop.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorShop.Entities.Concrete
{
    public class Post:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public Post()
        {

        }
        public Post(string title, string details)
        {
            Title = title;
            Details = details;
        }
        public override string ToString()
        {
            return $"{Id,-5} {Title,-30} {Details,-20}";
        }
    }
}
