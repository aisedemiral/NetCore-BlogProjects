using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class NotificationManager:INotificationService
{
     INotificationDal _notificationDal;

     public NotificationManager(INotificationDal notificationDal)
     {
         _notificationDal = notificationDal;
     }

     public void TAdd(Notification t)
    {
        throw new NotImplementedException();
    }

    public void TDelete(Notification t)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(Notification t)
    {
        throw new NotImplementedException();
    }

    public List<Notification> GetListAll()
    {
       return _notificationDal.GetListAll();
    }

    public Notification TGetById(int id)
    {
        throw new NotImplementedException();
    }
}