using System.Collections.Generic;
using System.Linq;

namespace BrightStarDb_App1
{
    public class BookService
    {
        private readonly IUnitOfWork _uow;

        public BookService()
            : this(DependencyResolver.Resolve<IUnitOfWork>())
        { }

        public BookService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }


        public IList<IBook> GetAll()
        {
            return _uow.Set<IBook>().OrderBy(item => item.Code).ToList();
        }

        public void Add(int code, string title)
        {
            _uow.Set<IBook>().Add(new Book
            {
                Code = code,
                Title = title,
            });
            _uow.SaveChanges();
        }

        public void Remove(IBook entity)
        {
            _uow.DeleteObject(entity);
            _uow.SaveChanges();
        }
    }
}