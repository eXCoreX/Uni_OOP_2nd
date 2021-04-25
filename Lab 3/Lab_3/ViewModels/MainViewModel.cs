using Lab_3.Commands;
using Lab_3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Lab_3.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            _Magazines = new ObservableCollection<Magazine>();
            var testMagazine = new Magazine(Periodicity.Weekly, "Acta Inform");
            var testAuthor = new Author("Edsger", "Dijksta", new DateTime(1930, 4, 11));
            var testArticle = new Article(testAuthor, "Hierarchical Ordering of Sequential Processes", 24, 8700);
            testMagazine.AddArticle(testArticle);
            Magazines.Add(testMagazine);
        }

        private ObservableCollection<Magazine> _Magazines = new ObservableCollection<Magazine>();
        public ObservableCollection<Magazine> Magazines
        {
            get { return _Magazines; }
            set
            {
                _Magazines = value;
                OnPropertyChanged(nameof(Magazines));
            }
        }

        private int _SelectedIndex = -1;
        public int SelectedIndex
        {
            get { return _SelectedIndex; }
            set
            {
                _SelectedIndex = value;
                OnPropertyChanged(nameof(SelectedIndex));
            }
        }

        private ICommand removeSelectedCommand;

        public ICommand RemoveSelectedCommand
        {
            get
            {
                if (removeSelectedCommand == null)
                {
                    removeSelectedCommand = new RelayCommand(RemoveSelected, CanRemoveSelected);
                }

                return removeSelectedCommand;
            }
        }

        private void RemoveSelected(object commandParameter)
        {
            Magazines.RemoveAt(SelectedIndex);
        }

        private bool CanRemoveSelected(object commandParameter)
        {
            return SelectedIndex != -1;
        }

        public void Load(string fileName)
        {
            var repo = new FileMagazineRepository();
            Magazines = repo.Load(fileName);
        }

        internal void Store(string fileName)
        {
            var repo = new FileMagazineRepository();
            repo.Store(Magazines, fileName);
        }
    }
}
