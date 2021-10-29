using Dapper;
using SimpleDapperTask.Domain.Abstractions;
using SimpleDapperTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDapperTask.DataAccess.DapperServer
{
    public class BookRepository : IBookRepository
    {
        public void AddData(Book data)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                connection.Open();
                connection.Execute("insert into Books(Name,Price,AuthorName)values(@BookName,@BookPrice,@BAuthorName)", new { @BAuthorName = data.AuthorName, @BookName = data.Name, @BookPrice = data.Price });
            }
        }

        public void DeleteData(int id)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                connection.Open();
                connection.Execute("Delete from Books Where Id=@BId ", new { @BId = id });
            }
        }

        public List<Book> GetAllData()
        {
            List<Book> products = new List<Book>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                connection.Open();
                products = connection.Query<Book>("select*from Books").ToList();
            }
            return products;
        }

        public Book GetData(int id)
        {
            Book book = new Book();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                connection.Open();
                book = connection.QueryFirstOrDefault<Book>("select *from Books where Id=@Bid", new { @Bid = id });
            }
            return book;


        }

        public void UpdateData(int id,Book data)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                connection.Open();
                connection.Execute("Update Books Set Name=@BName,Price=@BPrice,AuthorName=@BAuthorName where Id=@BId", new { @BAuthorName = data.AuthorName, @BName = data.Name, @BPrice = data.Price, @BId = id });
            }
        }
    }
}
