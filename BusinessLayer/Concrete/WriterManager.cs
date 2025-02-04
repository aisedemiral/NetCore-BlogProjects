using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class WriterManager:IWriterService
{
    private IWriterDal _writerDal;

    public WriterManager(IWriterDal writerDal)
    {
        _writerDal = writerDal;
    }

    public void TAdd(Writer t)
    {
        _writerDal.Insert(t);    
    }

    public void TDelete(Writer t)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(Writer t)
    {
        _writerDal.Update(t);
    }

    public List<Writer> GetListAll()
    {
        throw new NotImplementedException();
    }

    public Writer TGetById(int id)
    {
        return _writerDal.GetByID(id);
    }

    public List<Writer> GetWriterById(int id)
    {
        return _writerDal.GetListAll(x => x.WriterID == id);
    }
}