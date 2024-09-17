using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class AdminManager:IAdminService
{
     IAdminDal _AdminDal;

     public AdminManager(IAdminDal adminDal)
     {
          _AdminDal = adminDal;
     }

     public void TAdd(Admin t)
     {
          throw new NotImplementedException();
     }

     public void TDelete(Admin t)
     {
          throw new NotImplementedException();
     }

     public void TUpdate(Admin t)
     {
          throw new NotImplementedException();
     }

     public List<Admin> GetListAll()
     {
          throw new NotImplementedException();
     }

     public Admin TGetById(int id)
     {
          throw new NotImplementedException();
     }
}