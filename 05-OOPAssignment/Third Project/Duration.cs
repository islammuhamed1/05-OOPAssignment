using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOPAssignment.Third_Project
{
    internal class Duration
    {

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public override string ToString()
        {
            return $"{Hours} hours, {Minutes} minutes, {Seconds} seconds";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Duration other)
            {
                return this.Hours == other.Hours &&
                       this.Minutes == other.Minutes &&
                       this.Seconds == other.Seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            int hash = 17; 
            hash = hash * 23 + Hours.GetHashCode();   
            hash = hash * 23 + Minutes.GetHashCode();
            hash = hash * 23 + Seconds.GetHashCode();
            return hash;
        }
    }

}
