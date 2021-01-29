using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astronomy_11625
{


    class SpaceObject
    {
        string name;
        double perimeter;
        Material material;
        bool crossesEarthsOrbit;
        bool inSolarSystem;
        List<Measurement> measurements;

        public string Name
        {
            get => name;
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty");
                }
            }
        }
        public double Perimeter
        {
            get => perimeter;
            set
            {
                if (value >= 0.1)
                {
                    perimeter = value;
                }
                else
                {
                    throw new ArgumentException("Perimeter should be at least: 0.1 km");
                }
            }
        }
        internal Material Material { get => material; set => material = value; }
        public bool CrossesEarthsOrbit { get => crossesEarthsOrbit; set => crossesEarthsOrbit = value; }
        public bool InSolarSystem { get => inSolarSystem; set => inSolarSystem = value; }
        internal List<Measurement> Measurements { get => measurements; }

        public SpaceObject(string name, double perimeter, Material material, bool crossesEarthsOrbit, bool inSolarSystem)
        {
            Name = name;
            Perimeter = perimeter;
            Material = material;
            CrossesEarthsOrbit = crossesEarthsOrbit;
            InSolarSystem = inSolarSystem;
            measurements = new List<Measurement>();
        }
        public SpaceObject(string[] csvLine)
        {
            Name = csvLine[0];
            Perimeter = Convert.ToDouble(csvLine[1]);
            Material = (Material)Enum.Parse(typeof(Material), csvLine[2]);
            CrossesEarthsOrbit = bool.Parse(csvLine[3]);
            InSolarSystem = bool.Parse(csvLine[4]);
            measurements = new List<Measurement>();
        }
        public double AverageIntensity()
        {
            return measurements.Sum(x => Convert.ToInt32(x.Priority)) / measurements.Count;
        }

        public override string ToString()
        {
            return $"{name}";
        }
        public string CSVformat()
        {
             return $"{name},{perimeter},{material},{crossesEarthsOrbit},{inSolarSystem}";
        }
    }
}
