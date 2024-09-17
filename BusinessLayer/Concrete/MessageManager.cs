using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class MessageManager:IMessageService
{
    private IMessageDal _messageDal;
     IMessageService _messageServiceImplementation;

     public MessageManager(IMessageDal messageDal)
     {
         _messageDal = messageDal;
     }

     public void TAdd(Message t)
    {
        _messageServiceImplementation.TAdd(t);
    }

    public void TDelete(Message t)
    {
        _messageServiceImplementation.TDelete(t);
    }

    public void TUpdate(Message t)
    {
        _messageServiceImplementation.TUpdate(t);
    }

    public List<Message> GetListAll()
    {
        return _messageDal.GetListAll();
    }

    public Message TGetById(int id)
    {
        return _messageServiceImplementation.TGetById(id);
    }

    public List<Message> GetInboxListByWriter(string p)
    {
        return _messageDal.GetListAll(x=>x.Receiver==p);
    }
}