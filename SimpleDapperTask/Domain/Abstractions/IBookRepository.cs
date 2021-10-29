using ProjectWithMvvm.Domain.Abstractions;
using SimpleDapperTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDapperTask.Domain.Abstractions
{
    public interface IBookRepository:IRepository<Book>
    {
    }
}
