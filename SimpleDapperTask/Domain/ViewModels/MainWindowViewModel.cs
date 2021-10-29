using ProjectWithMvvm.Commands;
using ProjectWithMvvm.Domain.ViewModels;
using SimpleDapperTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDapperTask.Domain.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private Book selectedBook;

        public Book SelectedBooks
        {
            get { return selectedBook; }
            set { selectedBook = value; OnPropertyChanged(); }
        }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand UpdateCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand SelectBookCommand { get; set; }
        public MainWindowViewModel(MainWindow mainWindow)
        {
            mainWindow.mainDataGrid.ItemsSource = App.Db.BookRepository.GetAllData();
            AddCommand = new RelayCommand((sender) =>
            {
                try
                {
                    App.Db.BookRepository.AddData(new Book
                    {
                        Name = mainWindow.nameTxtbx.Text,
                        AuthorName = mainWindow.authorNameTxtbx.Text,
                        Price = decimal.Parse(mainWindow.priceTxtbx.Text),
                    });
                    mainWindow.mainDataGrid.ItemsSource = App.Db.BookRepository.GetAllData();
                }
                catch (Exception)
                {

                }

            });

            UpdateCommand = new RelayCommand((sender) =>
            {
                try
                {
                    App.Db.BookRepository.UpdateData(SelectedBooks.Id, new Book
                    {
                        Name = mainWindow.nameTxtbx.Text,
                        AuthorName = mainWindow.authorNameTxtbx.Text,
                        Price = decimal.Parse(mainWindow.priceTxtbx.Text),
                    });
                    mainWindow.mainDataGrid.ItemsSource = App.Db.BookRepository.GetAllData();
                }
                catch (Exception)
                {

                }

            });

            DeleteCommand = new RelayCommand((sender) =>
            {
                try
                {
                    App.Db.BookRepository.DeleteData(SelectedBooks.Id);
                    mainWindow.mainDataGrid.ItemsSource = App.Db.BookRepository.GetAllData();
                }
                catch (Exception)
                {

                }

            });

            SelectBookCommand = new RelayCommand((sender) =>
            {
                if (SelectedBooks != null)
                {
                    var Book = App.Db.BookRepository.GetData(SelectedBooks.Id);
                    SelectedBooks = Book;
                }
            });
        }

    }
}
