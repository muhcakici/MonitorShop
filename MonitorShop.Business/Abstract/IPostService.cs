using MonitorShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MonitorShop.Business.Abstract
{
    public interface IPostService
    {
        List<Post> GetAll(Expression<Func<Post, bool>> filter = null);
        Monitor Get(Expression<Func<Post, bool>> filter);
        void Add(Post entity);
        void Update(Post entity);
        void Delete(Post entity);
    }
}
