using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Abstarct;

public interface IMessageService:IGenericService<Message>
{
  List<Message> GetInboxListByWriter(string p);
}