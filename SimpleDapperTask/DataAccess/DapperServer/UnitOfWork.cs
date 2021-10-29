using ProjectWithMvvm.Domain.Abstractions;
using SimpleDapperTask.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDapperTask.DataAccess.DapperServer
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBookRepository BookRepository =>new  BookRepository();
    }
}
