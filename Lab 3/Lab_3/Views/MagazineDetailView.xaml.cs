using Lab_3.ViewModels;
using System.Windows;

namespace Lab_3.Views
{
    /// <summary>
    /// Interaction logic for MagazineDetailView.xaml
    /// </summary>
    public partial class MagazineDetailView : Window
    {
        private readonly MagazineDetailViewModel vm;

        public MagazineDetailView()
        {
            this.vm = new MagazineDetailViewModel();
            InitializeComponent();
            DataContext = vm;
        }

        public MagazineDetailView(MagazineDetailViewModel vm)
        {
            this.vm = vm;
            InitializeComponent();
            DataContext = vm;
        }
    }
}
