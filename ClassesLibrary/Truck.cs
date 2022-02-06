using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Truck : Vehicle
    {

        public float LoadCapacity { get; set; }

        public Truck(string make, string model, int year, float weight, float loadCapacity)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
            LoadCapacity = loadCapacity;
        }

        public override string ToString()
        {
            return string.Format("Make: {0}\n" +
                "Model: {1}\n" +
                "Year: {2}\n" +
                "Weight: {3}lbs\n" +
                "Load Capacity: {4}lbs", Make, Model, Year, Weight, LoadCapacity);
        }

    }
}
