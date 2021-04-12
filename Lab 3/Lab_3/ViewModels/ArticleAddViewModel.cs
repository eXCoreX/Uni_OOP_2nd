using Lab_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Lab_3.Commands;
using System.Windows;

namespace Lab_3.ViewModels
{
    public class ArticleAddViewModel : BaseViewModel
    {
        public ArticleAddViewModel()
        {
            var testAuthor = new Author("Edsger", "Dijksta", new DateTime(1930, 4, 11));
            var testArticle = new Article(testAuthor, "Hierarchical Ordering of Sequential Processes", 24, 8700);
            Article = testArticle;
        }

        public ArticleAddViewModel(MagazineAddViewModel magAddVM)
        {
            _rootVM = magAddVM;
            _Magazine = magAddVM?.Magazine ?? throw new ArgumentNullException("Magazine can't be null");
            Article = new Article(new Author("", "", new DateTime(2000, 1, 1)), "", 1, 0);
        }

        private readonly MagazineAddViewModel _rootVM = null;
        private readonly Magazine _Magazine = null;

        private Article _Article = null;
        public Article Article
        {
            get { return _Article; }
            set
            {
                _Article = value;
                OnPropertyChanged(nameof(Article));
            }
        }

        private ICommand articleCorfirmCommand;

        public ICommand ArticleCorfirmCommand
        {
            get
            {
                if (articleCorfirmCommand == null)
                {
                    articleCorfirmCommand = new RelayCommand(ArticleCorfirm);
                }

                return articleCorfirmCommand;
            }
        }

        private void ArticleCorfirm(object commandParameter)
        {
            _Magazine.AddArticle(Article);
            _rootVM.OnPropertyChanged(nameof(_rootVM.TotalPages));
            (commandParameter as Window).Close();
        }
    }
}
