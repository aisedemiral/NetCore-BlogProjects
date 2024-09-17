using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class BlogManager : IBlogService
{
    IBlogDal _blogDal;

    public BlogManager(IBlogDal blogDal)
    {
        _blogDal = blogDal;
    }



    public List<Blog> GetList()
    {
        return _blogDal.GetListAll();
    }

    public List<Blog> GetLast3Blog()
    {
        return _blogDal.GetListAll().Take(3).ToList();
    }


    public void TAdd(Blog t)
    {
        _blogDal.Insert(t);
    }

    public void TDelete(Blog t)
    {
        _blogDal.Delete(t);
    }

    public void TUpdate(Blog t)
    {
        _blogDal.Update(t);
    }

    public List<Blog> GetListAll()
    {
        throw new NotImplementedException();
    }


    public Blog TGetById(int id)
    {
        return _blogDal.GetByID(id);
    }

    public List<Blog> GetBlogByID(int id)
    {
        return _blogDal.GetListAll(x => x.BlogID == id);
    }
    public List<Blog> GetBlogListWithCategory()
    {
        return _blogDal.GetListWithCategory();
    }

    public List<Blog> GetBlogListByWriter(int id)
    {
        return _blogDal.GetListAll(x => x.WriterID == id);
    }

    public List<Blog> GetListWithCategoryByWriterBm(int id)
    {
        return _blogDal.GetListWithCategoryByWriter(id);
    }
    
}