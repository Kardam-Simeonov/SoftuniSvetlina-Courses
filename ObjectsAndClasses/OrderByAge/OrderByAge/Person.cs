namespace OrderByAge
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public Person(string userName, string userID, int userAge)
        {
            Name = userName;
            ID = userID;
            Age = userAge;
        }
    }
}