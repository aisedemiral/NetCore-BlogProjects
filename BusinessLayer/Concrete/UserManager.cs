using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class UserManager:IUserService
{
     IUserDal _userDal;

     public UserManager(IUserDal userDal)
     {
         _userDal = userDal;
     }

     public void TAdd(AppUser t)
    {
        throw new NotImplementedException();
    }

    public void TDelete(AppUser t)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(AppUser t)
    {
        _userDal.Update(t);
    }

    public List<AppUser> GetListAll()
    {
        throw new NotImplementedException();
    }

    public AppUser TGetById(int id)
    {
        return _userDal.GetByID(id);
    }
}