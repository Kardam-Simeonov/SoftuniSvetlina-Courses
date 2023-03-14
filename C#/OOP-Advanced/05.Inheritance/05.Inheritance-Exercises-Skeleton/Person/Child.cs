using System.Text;

namespace Person1
{
    public class Child : Person
    {
        private Person mother;
        private Person father;
        public Child(string name, int age, Person mother, Person father) : base(name, age)
        {
            Mother = mother;
            Father = father;
        }

        public Person Mother
        {
            get { return mother; }
            set { mother = value; }
        }

        public Person Father
        {
            get { return father; }
            set { father = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(base.ToString() + $", Mother: {this.Mother.Name}, Father: {this.Father.Name}"));

            return sb.ToString();
        }
    }
}