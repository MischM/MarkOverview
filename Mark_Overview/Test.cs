using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark_Overview
{
    public class Test
    {
        #region Properties
        /*topic,mark, points, max, avr, weight,date */
        public string Topic { get; private set; }
        public double Mark { get; private set; }
        public double Points { get; private set; }
        public int MaxPoints { get; private set; }
        public double Avg { get; private set; }
        public double Weighting { get; private set; }
        public DateTime Date { get; private set; }
        public Subject TestSubject { get; set; }
        #endregion

        #region Constructors
        public Test() { }
        public Test(string topic, double mark, double points, int max, double avr, double weight, DateTime date)
        {
            Topic = topic;
            Mark = mark;
            Points = points;
            MaxPoints = max;
            Avg = avr;
            Weighting = weight;
            Date = date;
        }
        public Test(Subject sub, string topic, double mark, double points, int max, double avr, double weight, DateTime date)
        {
            TestSubject = sub;
            Topic = topic;
            Mark = mark;
            Points = points;
            MaxPoints = max;
            Avg = avr;
            Weighting = weight;
            Date = date;
        }
        #endregion
    }
}
