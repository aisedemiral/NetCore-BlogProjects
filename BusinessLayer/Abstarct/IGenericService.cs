namespace BusinessLayer.Abstarct;

public interface IGenericService<T>
{
    void TAdd(T t);
    void TDelete(T t);
    void TUpdate(T t);
    List<T> GetListAll();
    T TGetById(int id);
}
