using System.Collections;
using System.Collections.Generic;

namespace Lab_2_Task_1
{
    class Garage : IEnumerable<Car>
    {
        private readonly List<Car> cars;

        public IEnumerator<Car> GetEnumerator()
        {
            return ((IEnumerable<Car>)cars).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)cars).GetEnumerator();
        }

        public Garage(List<Car> cars)
        {
            this.cars = cars;
        }
    }
}
