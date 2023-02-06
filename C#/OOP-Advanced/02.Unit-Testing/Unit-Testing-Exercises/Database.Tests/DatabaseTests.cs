using NUnit.Framework;
using P01_Database;
using System;


namespace Tests
{
    public class DatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Database_DefaultConstructor()
        {
            int[] input = { 1, 2, 3, 4, 5 };

            var db = new Database(input);

            Assert.AreEqual(input.Length, db.Count);
        }

        [Test]
        public void Test_Database_ConstructorException()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

            Assert.Throws<InvalidOperationException>(() => new Database(input));
        }

        [Test]
        public void Test_Database_Add()
        {
            int[] input = { 1, 2, 3, 4 };

            var db = new Database(input);
            db.Add(5);

            Assert.AreEqual(db.Fetch()[db.Count - 1], 5);
        }

        [Test]
        public void Test_Database_Remove()
        {
            int[] input = { 1, 2, 3, 4 };

            var db = new Database(input);
            db.Remove();

            Assert.AreEqual(db.Fetch()[db.Count - 1], 3);
        }

        [Test]
        public void Test_Database_RemoveException()
        {
            var db = new Database();

            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }
    }
}