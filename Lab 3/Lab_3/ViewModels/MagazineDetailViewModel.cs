using Lab_3.Commands;
using Lab_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Lab_3.ViewModels
{
    public class MagazineDetailViewModel : BaseViewModel
    {
        public MagazineDetailViewModel()
        {
            var testMagazine = new Magazine(Periodicity.Weekly, "Acta Inform");
            var testAuthor = new Author("Edsger", "Dijksta", new DateTime(1930, 4, 11));
            var testArticle = new Article(testAuthor, "Hierarchical Ordering of Sequential Processes", 24, 8700);
            testMagazine.AddArticle(testArticle);
            Magazine = testMagazine;
        }

        public MagazineDetailViewModel(MainViewModel mainVM)
        {
            Magazine = mainVM?.Magazines[mainVM.SelectedIndex] ?? throw new ArgumentNullException("Magazine can't be null");
        }

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
    }
}
