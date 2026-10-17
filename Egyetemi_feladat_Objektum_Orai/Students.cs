using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
namespace Egyetemi_feladat_Objektum_Orai
{
    internal class Students
    {
        string Name;
        int Point;
        public int point
        {
            get { return Point; }  
            set 
            { 
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Point must be between 0 and 100.");
                }
                    Point = value;
            }
        }
        public string name
        {
            get { return Name; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                Name = value; 
            }
        }
        public Students(string name, int point)
        {
            this.Name = name;
            this.Point = point;
        }
        public virtual string Visualize()
        {
            return $"Név: {Name}, Pontszám: {Point}, Osztályzat: {CalculateGrade()}";
        }
        private int CalculateGrade()
        {
            if (Point > 89)
                return 5;
            else if (Point > 79)
                return 4;
            else if (Point > 64)
                return 3;
            else if (Point > 49)
                return 2;
            else
                return 1;
        }
    }
}