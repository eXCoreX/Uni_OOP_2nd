using Lab_3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
