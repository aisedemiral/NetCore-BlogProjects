using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using Mvc_Projem.EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfWriterRepository:GenericRepository<Writer>,IWriterDal
{
    
}