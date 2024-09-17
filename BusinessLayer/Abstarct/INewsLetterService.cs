using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Abstarct;

public interface INewsLetterService
{
    void AddNewsLetter(NewsLetter newsLetter);
    
}