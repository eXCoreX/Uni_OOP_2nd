using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Models
{
    interface IMagazineRepository
    {
        ObservableCollection<Magazine> Load(object location);

        void Store(ObservableCollection<Magazine> magazines, object location);
    }
}
