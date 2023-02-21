using NUnit.Framework;
using System;
using UnitTesting;

namespace ArrayListTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_ArrayList_Constructor()
        {
            ArrayList arr = new ArrayList();

            Assert.AreEqual(0, arr.Count);
        }

        [Test]
        public void Test_ArrayList_Add()
        {
            ArrayList arr = new ArrayList();

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);

            Assert.AreEqual(3, arr.Count);
        }

        [Test]
        public void Test_ArrayList_CountFreePositions()
        {
            ArrayList arr = new ArrayList();

            arr.Add(1);

            Assert.AreEqual(1, arr.CountFreePositions());
        }

        [Test]
        public void Test_ArrayList_Cut()
        {
            ArrayList arr = new ArrayList();

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Cut(2);

            Assert.AreEqual(0, arr.CountFreePositions());
            Assert.AreEqual(1, arr.Count);
        }

        [Test]
        public void Test_ArrayList_CutException()
        {
            ArrayList arr = new ArrayList();

            arr.Add(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => arr.Cut(2));
        }

        [Test]
        public void Test_ArrayList_Change()
        {
            ArrayList arr = new ArrayList();

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);

            Assert.AreEqual(1, arr.Change(2, 4));
        }
    }
}