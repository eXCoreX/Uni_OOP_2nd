using Lab_3.ViewModels;
using System.Windows;

namespace Lab_3.Views
{
    /// <summary>
    /// Interaction logic for ArticleAddView.xaml
    /// </summary>
    public partial class ArticleAddView : Window
    {
        private readonly ArticleAddViewModel vm;

        public ArticleAddView()
        {
            this.vm = new ArticleAddViewModel();
            InitializeComponent();
            DataContext = vm;
        }

        public ArticleAddView(ArticleAddViewModel vm)
        {
            this.vm = vm;
            InitializeComponent();
            DataContext = vm;
        }
    }
}
