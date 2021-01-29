using System;

namespace astronomy_11625
{
    class Measurement
    {
        SpaceObject so;
        DateTime observed;
        string log;
        Priority priority;
        string name;

        public DateTime Observed { 
            get => observed;
            private set
            {
                if (value >= DateTime.Now)
                {
                    observed = value;
                }
                else
                {
                    throw new ArgumentException("Observation time should be at least now");
                } 
            }  
        }
        public string Log { get => log; set => log = value; }
        internal Priority Priority { get => priority; private set => priority = value; }
        internal SpaceObject So { get => so; set => so = value; }
        public string Name { get => name; set => name = value; }

        public Measurement(DateTime observed, string log, Priority priority, SpaceObject so)
        {
            Observed = observed;
            Log = log;               
            Priority = priority;
            So = so;
        }
        public Measurement(string[] csvline)
        {
            Name = csvline[0];
            Observed = Convert.ToDateTime(csvline[1]);
            Log = csvline[2];
            Priority = (Priority)Enum.Parse(typeof(Priority), csvline[3]);
        }

        public string CSVformat()
        {
            return $"{So.Name},{observed},{log},{priority}";
        }
        public override string ToString()
        {
            return $"{ so.Name } { observed }";
        }
    }
}
