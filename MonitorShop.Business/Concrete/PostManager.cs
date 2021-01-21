using MonitorShop.Business.Abstract;
using MonitorShop.DataAccess.Abstract;
using MonitorShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MonitorShop.Business.Concrete
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public void Add(Post entity)
        {
            _postDal.Add(entity);
        }

        public void Delete(Post entity)
        {
            _postDal.Delete(entity);
        }

        public Monitor Get(Expression<Func<Post, bool>> filter)
        {
            return null;
        }

        public List<Post> GetAll(Expression<Func<Post, bool>> filter = null)
        {
            return _postDal.GetAll(filter);
        }

        public void Update(Post entity)
        {
            _postDal.Update(entity);
        }
    }
}
