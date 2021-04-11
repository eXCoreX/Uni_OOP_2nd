using Lab_3.ViewModels;
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
            detailView.ShowDialog();
        }
    }
}
