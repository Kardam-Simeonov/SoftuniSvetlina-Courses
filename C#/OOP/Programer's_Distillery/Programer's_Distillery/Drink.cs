using System;

namespace Programer_s_Distillery
{
    internal class Drink : IComparable
    {
        private double codeSkill;

        public double CodeSkill
        {
            get { return codeSkill; }
            set { codeSkill = value; }
        }

        public Drink()
        {
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}