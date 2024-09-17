using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class NewsLetterManeger(EfNewsLetterRepository efNewsLetterRepository) :INewsLetterService
{
    INewsletterDal _newsletterDal;

    public void AddNewsLetter(NewsLetter newsLetter)
    { 
        _newsletterDal.Insert(newsLetter);
    }
}
