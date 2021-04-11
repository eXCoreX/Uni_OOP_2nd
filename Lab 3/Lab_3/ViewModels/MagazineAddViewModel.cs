using Lab_3.Commands;
using Lab_3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Lab_3.ViewModels
{
    public class MagazineAddViewModel : BaseViewModel
    {
        public MagazineAddViewModel()
        {
            var testMagazine = new Magazine(Periodicity.Weekly, "Acta Inform");
            var testAuthor = new Author("Edsger", "Dijksta", new DateTime(1930, 4, 11));
            var testArticle = new Article(testAuthor, "Hierarchical Ordering of Sequential Processes", 24, 8700);
            testMagazine.AddArticle(testArticle);
            Magazine = testMagazine;
        }

        public MagazineAddViewModel(MainViewModel mainVM)
        {
            Magazine = new Magazine(Periodicity.Weekly, "New magazine");
            magazines = mainVM?.Magazines;
        }

        private readonly ObservableCollection<Magazine> magazines;

        private Magazine _Magazine = null;

        public Magazine Magazine
        {
            get { return _Magazine; }
            set
            {
                _Magazine = value;
                OnPropertyChanged(nameof(Magazine));
            }
        }

        public int TotalPages
        {
            get
            {
                int result = 0;
                foreach (var article in Magazine.Articles)
                {
                    result += article.PageCount;
                }
                return result;
            }
        }

        private ICommand confirmCommand;

        public ICommand ConfirmCommand
        {
            get
            {
                if (confirmCommand == null)
                {
                    confirmCommand = new RelayCommand(Confirm);
                }

                return confirmCommand;
            }
        }

        private void Confirm(object commandParameter)
        {
            magazines.Add(Magazine);
            (commandParameter as Window).Close();
        }
    }
}
