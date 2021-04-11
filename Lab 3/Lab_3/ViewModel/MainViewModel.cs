using Lab_3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            _Magazines = new List<Magazine>();
            var testMagazine = new Magazine(Periodicity.Weekly, "Acta Inform");
            var testAuthor = new Author("Edsger", "Dijksta", new DateTime(1930, 4, 11));
            var testArticle = new Article(testAuthor, "Hierarchical Ordering of Sequential Processes", 24, 8700);
            testMagazine.AddArticle(testArticle);
            Magazines.Add(testMagazine);
        }

        private List<Magazine> _Magazines = new List<Magazine>();
        public List<Magazine> Magazines
        {
            get { return _Magazines; }
            set
            {
                _Magazines = value;
                OnPropertyChanged(nameof(Magazines));
            }
        }
    }
}
