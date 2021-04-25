using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Xml;

namespace Lab_3.Models
{
    public class FileMagazineRepository : IMagazineRepository
    {
        public ObservableCollection<Magazine> Load(object location)
        {
            if (location is string)
            {
                string filePath = location as string;
                var serializer = new DataContractSerializer(typeof(ObservableCollection<Magazine>));
                using (var reader = XmlReader.Create(filePath))
                {
                    var magazines = (ObservableCollection<Magazine>)serializer.ReadObject(reader);
                    return magazines;
                }
            }
            else
            {
                throw new ArgumentException("location should be string with path to file");
            }
        }
        public void Store(ObservableCollection<Magazine> magazines, object location)
        {
            if (location is string)
            {
                string filePath = location as string;
                var serializer = new DataContractSerializer(typeof(ObservableCollection<Magazine>));
                using (var writer = XmlWriter.Create(filePath))
                {
                    serializer.WriteObject(writer, magazines);
                }
            }
            else
            {
                throw new ArgumentException("location should be string with path to file");
            }
        }
    }
}
