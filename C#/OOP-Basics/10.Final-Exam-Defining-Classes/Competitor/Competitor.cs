using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ImplementCompetitor
{
    public class Competitor<T> : IComparable<Competitor<T>>
    {
        private string name;
        private int age;
        private List<T> scores;

        public List<T> Scores
        {
            get { return scores; }
            set { scores = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value >= 10 ? value : age; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Competitor(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Scores = new List<T>();
        }

        public void Add(T score)
        {
            Scores.Add(score);
        }

        public int CountCompetitions()
        {
            return Scores.Count;
        }

        public T ChangeLastScore(T newScore)
        {
            var temp = Scores[Scores.Count - 1];
            Scores[Scores.Count - 1] = newScore;

            return temp;
        }

        public int CompareTo([AllowNull] Competitor<T> other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result == 0)
                result = this.Age.CompareTo(other.Age);

            return result;
        }
    }
}