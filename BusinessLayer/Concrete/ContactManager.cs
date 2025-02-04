using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class ContactManager:IContactService
{ 
    IContactDal _contactDal;

    public ContactManager(IContactDal contactDal)
    {
        _contactDal = contactDal;
    }

    public void ContactAdd(Contact contact)
    {
        _contactDal.Insert(contact);
    }
}