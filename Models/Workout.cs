//Файл Workout.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SportApp.Models
{
    public class Workout
    {
        public string Name { get; set; }
        public string MuscleGruoup { get; set; }
        public DateTime StartTime { get; set; }
        public Workout(string name, DateTime time )
        {
            if (string.IsNullOrEmpty(name)) Name = "Unknown";
            else Name = name;

            StartTime = time;
        }
    }
}
