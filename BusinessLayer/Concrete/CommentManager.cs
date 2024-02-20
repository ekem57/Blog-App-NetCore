using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commantDal;

        public CommentManager(ICommentDal commantDal)
        {
            _commantDal = commantDal;
        }

        public void CommentAdd(Comment comment)
        {
            _commantDal.Insert(comment);
        }

        public List<Comment> GetList(int id)
        {
            return _commantDal.GetListAll(x => x.BlogID == id);
        }

        public List<Comment> GetListWithBlog()
        {
            return _commantDal.GetListWithBlog();
        }
    }
}
