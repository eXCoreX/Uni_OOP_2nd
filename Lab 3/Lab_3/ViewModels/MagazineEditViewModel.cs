using Lab_3.Commands;
using Lab_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab_3.ViewModels
{
    public class MagazineEditViewModel : BaseViewModel
    {
        public MagazineEditViewModel()
        {
            var testMagazine = new Magazine(Periodicity.Weekly, "Acta Inform");
            var testAuthor = new Author("Edsger", "Dijksta", new DateTime(1930, 4, 11));
            var testArticle = new Article(testAuthor, "Hierarchical Ordering of Sequential Processes", 24, 8700);
            testMagazine.AddArticle(testArticle);
            _OriginalMag = testMagazine;
            Magazine = _OriginalMag.Clone() as Magazine;
        }

        public MagazineEditViewModel(MainViewModel mainVM)
        {
            _OriginalMag = mainVM?.Magazines[mainVM.SelectedIndex] ?? throw new ArgumentNullException("Magazine can't be null");
            Magazine = _OriginalMag.Clone() as Magazine;
        }

        private Magazine _Magazine = null;
        private readonly Magazine _OriginalMag = null;

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

        public void CommitChanges()
        {
            _OriginalMag.Name = Magazine.Name;
            _OriginalMag.Articles = Magazine.Articles;
            _OriginalMag.Periodicity = Magazine.Periodicity;
        }

        private ICommand saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                {
                    saveCommand = new RelayCommand(x => CommitChanges());
                }

                return saveCommand;
            }
        }

        public bool ChangesPresent
        {
            get
            {
                return _OriginalMag != Magazine;
            }
        }
    }
}
