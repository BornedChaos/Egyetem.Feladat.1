using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Egyetemi_feladat_Objektum_Orai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students[] students = Read_and_write();
            Console.WriteLine("A diákok átlaga: " + Calculateaverage(students));
            //Students student = new Students("Béla", 80);
        }
        static Students[] Read_and_write()
        {
            string[] lines = File.ReadAllLines("eredmenyek.txt");
            int n = lines.Length;
            Students[] students = new Students[n];
            for (int i = 0; i < n; i++)
            {
                string[] data = lines[i].Split(';');
                if (data[2] == "levelező")
                {
                    students[i] = new Distance_learner(data[0], int.Parse(data[1]), data[2]);
                }
                else
                {
                    students[i] = new Students(data[0], int.Parse(data[1]));
                }
                Console.WriteLine(students[i].Visualize());
            }
            return students;
        }
        static int Calculateaverage(Students[] students)
        {
            int sum = 0;
            foreach (var student in students)
            {
                sum +=  student.point;
            }
            return sum / students.Length;
        }
    }
}