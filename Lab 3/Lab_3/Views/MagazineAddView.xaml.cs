using Lab_3.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace Lab_3.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MagazineAddView : Window
    {
        private readonly MagazineAddViewModel vm;

        public MagazineAddView()
        {
            this.vm = new MagazineAddViewModel();
            InitializeComponent();
            DataContext = vm;
        }

        public MagazineAddView(MagazineAddViewModel vm)
        {
            this.vm = vm;
            InitializeComponent();
            DataContext = vm;
        }

        private void OnAddNewArticleClick(object sender, MouseButtonEventArgs e)
        {
            var avm = new ArticleAddViewModel(DataContext as MagazineAddViewModel);
            var addArticleView = new ArticleAddView(avm);
            addArticleView.ShowDialog();
        }
    }
}
