using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clasa_Elevi
{
 
    class Program
    {
        static List<Elev> media = new List<Elev>();
        //main
        static void Main(string[] args)
        {
            List<Elev> students = GenerareIntrare(@"..\..\intrare.txt");
            media = CalculMedie(students);
            IComparer<Elev> comparer = new Ordine();
            media.Sort(comparer);
            foreach (Elev student in media)
            {
                Console.WriteLine($"{student.Nume} are media: {student.Average}");
            }
            GenerareIesire(@"..\..\iesire.txt");
            Console.ReadLine();
        }

        public static List<Elev> GenerareIntrare(string filepath)
        {
            List<Elev> students = new List<Elev>();
            StreamReader sr = sr = new StreamReader(filepath);
            Elev elev = new Elev();
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] datas = line.Split(',');
                string[] grades = datas[3].Split(' ');
                elev = new Elev(datas[0], datas[1], datas[2], grades);
                students.Add(elev);
                line = sr.ReadLine();
            }
            return students;
        }
        private static void GenerareIesire(string filepath)
        {
            StreamWriter s = new StreamWriter(filepath);
            foreach (var student in media)
            {
                s.WriteLine(student);
            }
            s.Close();
        }
        private static List<Elev> CalculMedie(List<Elev> studenti)
        {
            double mediaStud = 0;
            foreach (var student in studenti)
            {
                mediaStud = student.GetAverage(student.Grades);
                Elev elev = new Elev(student.numeFam, student.prenume, mediaStud);
                media.Add(elev);
            }

            return media;
        }
       
    }
    public class Elev
    {
        public string prenume;
        public string numeFam;
        private int numberOfGrades;
        private string[] grades;
        private double media;
        public string Nume => numeFam + prenume;
        public string[] Grades => grades;
        public double Average => media;
        public Elev()
        {

        }
        public Elev(string numeFam, string prenume, string numberOfGrades, string[] grades)
        {
            this.prenume = prenume;
            this.numeFam = numeFam;
            this.numberOfGrades = int.Parse(numberOfGrades);
            this.grades = grades;
        }

        public Elev(string numeFam, string prenume, double average)
        {
            this.numeFam = numeFam;
            this.prenume = prenume;
            this.media = average;
        }
        public double GetAverage(string[] note)
        {
            double media = 0;
            foreach (var grade in grades)
            {
                media += int.Parse(grade);
            }
            media /= grades.Length;
            return media;
        }
        public override string ToString()
        {
            return $"{this.Nume} - media: {this.media}";
        }
    }
    public class Ordine : IComparer<Elev>
    {
        public int Compare(Elev x, Elev y)
        {
            int compareAverage = x.Average.CompareTo(y.Average);
            if (compareAverage == 0)
            {
                int comparenumeFam = x.numeFam.CompareTo(y.numeFam);
                if (comparenumeFam == 0)
                {
                    return x.prenume.CompareTo(y.prenume);
                }
                return comparenumeFam;
            }
            return compareAverage;
        }
    }
}