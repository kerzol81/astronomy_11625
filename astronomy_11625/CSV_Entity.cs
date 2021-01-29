using System;
using System.IO;

namespace astronomy_11625
{
    static class CSV_Entity
    {
        static string spaceObjectsCSV = "stars.csv";
        static string measurementsCSV = "measurements.csv";

        public static void WriteSpaceObjects()
        {
            foreach (var item in DataStore.SpaceObjects)
            {
                try
                {
                    File.WriteAllText(spaceObjectsCSV, item.CSVformat());
                }
                catch (Exception)
                {

                    throw new Exception();
                }
                
            }
        }
        public static void WriteMeasurements()
        {
            foreach (var item in DataStore.Measurements)
            {
                File.WriteAllLines(measurementsCSV, item.CSVformat().Split(','));
            }
        }

        public static void ReadSpaceObjects()
        {
            try
            {
                StreamReader s = new StreamReader(spaceObjectsCSV);
                while (s.EndOfStream)
                {
                    var csvline = s.ReadLine().Split(',');
                    DataStore.SpaceObjects.Add(new SpaceObject(csvline));
                }
                s.Close();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("missing csv file");
            }
        }

        public static void ReadMeasurements()
        {
            try
            {
                StreamReader s = new StreamReader(measurementsCSV);
                while (s.EndOfStream)
                {
                    var csvline = s.ReadLine().Split(',');
                    DataStore.Measurements.Add(new Measurement(csvline));
                }
                s.Close();
            }
            catch (Exception)
            {

                throw new FileNotFoundException("missing csv file");
            }
        }
        
    }
}
