using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp
{
    public class Workout
    {

        public string Name { get; set; }
        public DateTime StartTime { get; set; }

        public Workout()
        {
            Name = "Unknown";
            StartTime = DateTime.Now;
        }
        public Workout(string name)
        {
            Name = name ?? "Unknown";
            StartTime = DateTime.Now;
        }
        public Workout(DateTime time)
        {
            Name = "Unknown";
            StartTime = time;
        }
        public Workout(string name, DateTime time)
        {
            Name = name ?? "Unknown";
            StartTime = time;
        }
    }
}
