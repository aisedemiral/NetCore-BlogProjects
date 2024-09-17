using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Abstarct;

public interface IWriterService:IGenericService<Writer>
{
    List<Writer> GetWriterById(int id);

}