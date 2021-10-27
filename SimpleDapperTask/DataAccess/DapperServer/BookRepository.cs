using SimpleDapperTask.Domain.Abstractions;
using SimpleDapperTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDapperTask.DataAccess.DapperServer
{
    public class BookRepository : IBookRepository
    {
        public void AddData(Book data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Book data)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.ObservableCollection<Book> GetAllData()
        {
            throw new NotImplementedException();
        }

        public Book GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Book data)
        {
            throw new NotImplementedException();
        }
    }
}
