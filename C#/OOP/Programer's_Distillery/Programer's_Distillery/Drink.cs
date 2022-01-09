using System;
using System.Linq;

namespace Programer_s_Distillery
{
    internal class Drink : IComparable<Drink>
    {
        private decimal codeSkill;
        private decimal algoSkill;
        private decimal xpSkill;
        private decimal languageSkill;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal LanguageSkill
        {
            get { return languageSkill; }
            set { languageSkill = value >= 0 ? value : 0; }
        }


        public decimal XPSkill
        {
            get { return xpSkill; }
            set { xpSkill = value >= 0 ? value : 0; }
        }


        public decimal AlgoSkill
        {
            get { return algoSkill; }
            set { algoSkill = value >= 0 ? value : 0; }
        }


        public decimal CodeSkill
        {
            get { return codeSkill; }
            set { codeSkill = value >= 0 ? value : 0; }
        }


        public Drink(string name, decimal codeSkill, decimal algoSkill, decimal xpSkill, decimal languageSkill)
        {
            if (codeSkill + algoSkill + xpSkill + languageSkill != 1)
                Screen.Error("The sum of the ratio must be equal to 1");

            this.Name = name;
            this.CodeSkill = codeSkill;
            this.AlgoSkill = algoSkill;
            this.XPSkill = xpSkill;
            this.LanguageSkill = languageSkill;
        }

        public int GetHighestElement()
        {
            decimal[] ratio = { codeSkill, languageSkill,  xpSkill, algoSkill };

            return ratio.ToList().IndexOf(ratio.Max()) + 1;
        }

        public int CompareTo(Drink other)
        {
            int result = this.algoSkill.CompareTo(other.algoSkill);

            if (result == 0)
            {
                result = this.xpSkill.CompareTo(other.xpSkill);

                if (result == 0)
                {
                    result = this.languageSkill.CompareTo(other.languageSkill);

                    if (result == 0)
                    {
                        result = this.codeSkill.CompareTo(other.codeSkill);
                    }
                }
            }

            return result;
        }

        public override string ToString()
        {
            return $"{Name}({codeSkill:F2}/{algoSkill:F2}/{xpSkill:F2}/{languageSkill:F2})";
        }
    }
}