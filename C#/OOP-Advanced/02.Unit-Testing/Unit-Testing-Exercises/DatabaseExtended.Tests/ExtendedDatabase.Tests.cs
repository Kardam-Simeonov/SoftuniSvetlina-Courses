using NUnit.Framework;
//using P02_ExtendedDatabase;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_ExtendedDatabase_Constructor()
        {
            Person[] input = { new Person(1, "Nakov1"), new Person(2, "Nakov2") };

            var db = new ExtendedDatabase(input);

            Assert.AreEqual(db.Count, 2);
        }

        [Test]
        public void Test_ExtendedDatabase_ConstructorRepeatingName()
        {
            Person[] input = { new Person(1, "Nakov"), new Person(2, "Nakov") };

            Assert.Throws<InvalidOperationException>(() => new ExtendedDatabase(input));
        }

        [Test]
        public void Test_ExtendedDatabase_ConstructorRepeatingId()
        {
            Person[] input = { new Person(1, "Nakov1"), new Person(1, "Nakov2") };

            Assert.Throws<InvalidOperationException>(() => new ExtendedDatabase(input));
        }

        [Test]
        public void Test_ExtendedDatabase_ConstructorOverflow()
        {
            Person[] input = new Person[17];

            for (int i = 0; i < 17; i++)
                input[i] = new Person(i + 1, "Nakov" + i + 1);

            Assert.Throws<ArgumentException>(() => new ExtendedDatabase(input));
        }

        [Test]
        public void Test_ExtendedDatabase_AddOverflow()
        {
            Person[] input = new Person[16];

            for (int i = 0; i < 16; i++)
                input[i] = new Person(i + 1, "Nakov" + i + 1);

            var db = new ExtendedDatabase(input);

            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(17, "Nakov17")));
        }

        [Test]
        public void Test_ExtendedDatabase_Remove()
        {
            Person[] input = { new Person(1, "Nakov1"), new Person(2, "Nakov2") };

            var db = new ExtendedDatabase(input);
            db.Remove();

            Assert.AreEqual(1, db.Count);
        }

        [Test]
        public void Test_ExtendedDatabase_RemoveEmptyArray()
        {
            var db = new ExtendedDatabase();

            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }

        [Test]
        public void Test_ExtendedDatabase_FindById()
        {
            var person = new Person(1, "Nakov");

            var db = new ExtendedDatabase(person);

            Assert.AreEqual(db.FindById(1), person);
        }

        [Test]
        public void Test_ExtendedDatabase_FindByIdNegativeNumber()
        {
            var db = new ExtendedDatabase();

            Assert.Throws<ArgumentOutOfRangeException>(() => db.FindById(-1));
        }

        [Test]
        public void Test_ExtendedDatabase_FindByIdNotFound()
        {
            var person = new Person(1, "Nakov");

            var db = new ExtendedDatabase(person);

            Assert.Throws<InvalidOperationException>(() => db.FindById(0));
        }

        [Test]
        public void Test_ExtendedDatabase_FindByUsername()
        {
            var person = new Person(1, "Nakov");

            var db = new ExtendedDatabase(person);

            Assert.AreEqual(db.FindByUsername("Nakov"), person);
        }

        [Test]
        public void Test_ExtendedDatabase_FindByUsernameEmptyEntry()
        {
            var db = new ExtendedDatabase();

            Assert.Throws<ArgumentNullException>(() => db.FindByUsername(""));
        }

        [Test]
        public void Test_ExtendedDatabase_FindByUsernameNotFound()
        {
            var person = new Person(1, "Nakov");

            var db = new ExtendedDatabase(person);

            Assert.Throws<InvalidOperationException>(() => db.FindByUsername("Svetlin"));
        }
    }
}