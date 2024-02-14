using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace challange1
{
    internal class Student
    {
        public string Name;
        public int MatricMarks;
        public int FscMarks;
        public float EcatMarks;
        public Student(string name, int matricMarks, int fscMarks, float ecatMarks)
        {
            this.Name = name;
            this.MatricMarks = matricMarks;
            this.FscMarks = fscMarks;
            this.EcatMarks = ecatMarks;
        }
        public double CalculateAggregate()
        {
            double aggregate = (MatricMarks * 0.5) + (FscMarks * 0.3) + (EcatMarks * 0.2);
            return aggregate;           
        }
    }
}
