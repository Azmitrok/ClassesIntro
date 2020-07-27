using System;
using System.Reflection;

namespace ConsoleApp3
{
    public class WorkExperience
    {
        public Company Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Position { get; set; }

        public string Duties { get; set; }

    }
}