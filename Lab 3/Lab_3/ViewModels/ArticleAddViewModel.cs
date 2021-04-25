using Lab_3.Models;
using System;
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
            _Magazine = magAddVM?.Magazine ?? throw new ArgumentNullException("Magazine can't be null");
            _parentVM = magAddVM;
            Article = new Article(new Author("", "", new DateTime(2000, 1, 1)), "", 1, 0);
        }

        public ArticleAddViewModel(MagazineEditViewModel magEditVM)
        {
            _Magazine = magEditVM?.Magazine ?? throw new ArgumentNullException("Magazine can't be null");
            _parentVM = magEditVM;
            Article = new Article(new Author("", "", new DateTime(2000, 1, 1)), "", 1, 0);
        }

        private readonly Magazine _Magazine = null;
        private readonly BaseViewModel _parentVM = null;

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
            if (_parentVM is MagazineAddViewModel)
            {
                var casted = _parentVM as MagazineAddViewModel;
                _parentVM.OnPropertyChanged(nameof(casted.TotalPages));
            }
            else if (_parentVM is MagazineEditViewModel)
            {
                var casted = _parentVM as MagazineEditViewModel;
                _parentVM.OnPropertyChanged(nameof(casted.TotalPages));
            }
            (commandParameter as Window).Close();
        }
    }
}
