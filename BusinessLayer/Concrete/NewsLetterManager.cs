using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewletterDal _newletterDal;

        public NewsLetterManager(INewletterDal newletterDal)
        {
            _newletterDal = newletterDal;
        }
        public void AddNewsLetter(NewsLetter newsletter)
        {
            _newletterDal.Insert(newsletter);
        }

    }
}
