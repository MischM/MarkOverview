using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark_Overview
{
    public class Subject
    {
        #region Properties
        public string Description { get; private set; }
        private string Abbr { get; set; }
        //public List<Test> Tests = new List<Test>() { null };
        #endregion

        #region Constructors
        public Subject() { }
        public Subject(string desc, string abbr)
        {
            Description = desc;
            Abbr = abbr;
        }
        #endregion

    }
}