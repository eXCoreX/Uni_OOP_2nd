using Lab_3.ViewModels;
using System;
using System.Windows;
using System.Windows.Input;

namespace Lab_3.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void OnMagazineDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                var dvm = new MagazineDetailViewModel(DataContext as MainViewModel);
                var detailView = new MagazineDetailView(dvm);
                detailView.ShowDialog();
            }
        }

        private void OnAddNewClick(object sender, MouseButtonEventArgs e)
        {
            var avm = new MagazineAddViewModel(DataContext as MainViewModel);
            var detailView = new MagazineAddView(avm);
            detailView.ShowDialog();
        }

        private void OnViewDetailsClick(object sender, MouseButtonEventArgs e)
        {
            var dvm = new MagazineDetailViewModel(DataContext as MainViewModel);
            var detailView = new MagazineDetailView(dvm);
            detailView.ShowDialog();
        }

        private void OnEditClick(object sender, MouseButtonEventArgs e)
        {
            var evm = new MagazineEditViewModel(DataContext as MainViewModel);
            var detailView = new MagazineEditView(evm);
            var lastSelected = (DataContext as MainViewModel).SelectedIndex;
            detailView.ShowDialog();
            (DataContext as MainViewModel).SelectedIndex = lastSelected;
        }

        private void FileOpenClick(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog
            {
                Multiselect = false,
                Filter = "Magazine store file (*.msf)|*.msf"
            };

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                try
                {
                    (DataContext as MainViewModel).Load(dialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("File contains bad or corrupted data", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void FileSaveClick(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = ".msf",
                Filter = "Magazine store file (*.msf)|*.msf"
            };

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                (DataContext as MainViewModel).Store(dialog.FileName);
            }
        }
    }
}
