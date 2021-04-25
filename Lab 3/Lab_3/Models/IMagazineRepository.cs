using System.Collections.ObjectModel;

namespace Lab_3.Models
{
    interface IMagazineRepository
    {
        ObservableCollection<Magazine> Load(object location);

        void Store(ObservableCollection<Magazine> magazines, object location);
    }
}
