using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassesLibrary
{
    public class MotorHome : Vehicle
    {

        public int NbrOfBeds { get; set; }

        public MotorHome(string make, string model, int year, float weight, int nbrOfBeds)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
            NbrOfBeds = nbrOfBeds;
        }

        public override string ToString()
        {
            return string.Format("Make: {0}\n" +
                "Model: {1}\n" +
                "Year: {2}\n" +
                "Weight: {3}lbs\n" +
                "Number of beds: {4}\n", Make, Model, Year, Weight, NbrOfBeds);
        }

    }
}
