using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using Mvc_Projem.EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfAdminRepository:GenericRepository<Admin>,IAdminDal
{
    
}