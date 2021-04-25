using Lab_3.ViewModels;
using System.Windows;

namespace Lab_3.Views
{
    /// <summary>
    /// Interaction logic for MagazineEditView.xaml
    /// </summary>
    public partial class MagazineEditView : Window
    {
        private readonly MagazineEditViewModel vm;

        public MagazineEditView()
        {
            this.vm = new MagazineEditViewModel();
            InitializeComponent();
            DataContext = vm;
        }

        public MagazineEditView(MagazineEditViewModel vm)
        {
            this.vm = vm;
            InitializeComponent();
            DataContext = vm;
        }

        private void OnWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if ((DataContext as MagazineEditViewModel).ChangesPresent)
            {
                if (MessageBox.Show("Save changes?", "", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
                {
                    (DataContext as MagazineEditViewModel).CommitChanges();
                }
            }
        }

        private void OnAddNewArticleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ArticleAddViewModel avm = new ArticleAddViewModel((DataContext as MagazineEditViewModel));
            var addArticleView = new ArticleAddView(avm);
            addArticleView.ShowDialog();
        }
    }
}
