using ProjectWithMvvm.Domain.Abstractions;
using SimpleDapperTask.DataAccess.DapperServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SimpleDapperTask
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IUnitOfWork Db;
        public App()
        {
            Db = new UnitOfWork();
        }
    }
}
