using NUnit.Framework;
using System;
using System.Collections.ObjectModel;

namespace Collections.Tests
{
    public class CollectionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Collections_Add()
        {
            // Arrange
            Collection<int> collection = new Collection<int>();

            // Act
            collection.Add(1);
            collection.Add(2);
            collection.Add(3);

            // Assert
            Assert.AreEqual(1, collection[0]);
            Assert.AreEqual(2, collection[1]);
            Assert.AreEqual(3, collection[2]);
        }

        [Test]
        public void Test_Collections_AddWithGrow()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(); 
            for (int i = 1; i <= 16; i++)
            {
                collection.Add(i);
            }
            
            //Act
            collection.Add(17);

            //Assert
            Assert.AreEqual(17, collection.Count);
            Assert.AreEqual(32, collection.Capacity);
        }


        [Test]
        public void Test_Collections_AddRange()
        {
            // Arrange
            Collection<int> collection = new Collection<int>();
            int[] itemsToAdd = { 1, 2, 3, 4, 5 };

            // Act
            collection.AddRange(itemsToAdd);

            // Assert
            Assert.AreEqual(5, collection.Count);
            for (int i = 0; i < itemsToAdd.Length; i++)
            {
                Assert.AreEqual(itemsToAdd[i], collection[i]);
            }
        }

        [Test]
        public void Test_Collections_AddRangeWithGrow()
        {
            // Arrange
            Collection<int> collection = new Collection<int>();
            int[] itemsToAdd = { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            collection.AddRange(itemsToAdd);

            // Act
            collection.AddRange(itemsToAdd);

            //Assert
            Assert.AreEqual(18, collection.Count);
            Assert.AreEqual(32, collection.Capacity);
        }

        [Test]
        public void Test_Collections_Clear()
        {
            // Arrange
            var collection = new Collection<int>(new[] { 1, 2, 3, 4, 5 });
            // Act
            collection.Clear();
            // Assert
            Assert.AreEqual(0, collection.Count, "Collection count is not 0 after clear");
        }

        [Test]
        public void Test_Collections_ConstructorMultipleItems()
        {
            //Arrange 
            int[] items = new int[] { 1, 2, 3 };

            //Act
            Collection<int> collection = new Collection<int>(items);

            //Assert
            Assert.AreEqual(3, collection.Count);
            Assert.AreEqual(16, collection.Capacity);
            for (int i = 0; i < collection.Count; i++)
                Assert.AreEqual(i + 1, collection[i]);
        }

        [Test]
        public void Test_Collections_ConstructorSingleItem()
        {
            //Arrange 
            int item = 1;

            //Act
            Collection<int> collection = new Collection<int>(item);

            //Assert
            Assert.AreEqual(1, collection.Count);
            Assert.AreEqual(16, collection.Capacity);
            Assert.AreEqual(1, collection[0]);
        }

        [Test]
        public void Test_Collections_EmptyConstructor()
        {
            // Arrange
            var collection = new Collection<int>();

            // Act

            // Assert
            Assert.AreEqual(16, collection.Capacity);
        }

        [Test]
        public void Test_Collections_ExchangeFirstLast()
        {
            // Arrange
            var collection = new Collection<int>(new int[] { 1, 2, 3, 4, 5 });

            // Act
            collection.Exchange(0, collection.Count - 1);

            // Assert
            Assert.AreEqual(5, collection[0]);
            Assert.AreEqual(1, collection[collection.Count - 1]);
        }

        [Test]
        public void Test_Collections_InsertAtBegining()
        {
            // Arrange
            var collection = new Collection<int>(new int[] { 1, 2, 3, 4, 5 });

            // Act
            collection.InsertAt(0, 6);

            // Assert
            Assert.AreEqual(6, collection[0]);
        }

        [Test]
        public void Test_Collections_InsertAtEnd()
        {
            // Arrange
            var collection = new Collection<int>(new int[] { 1, 2, 3, 4, 5 });

            // Act
            collection.InsertAt(collection.Count, 6);

            // Assert
            Assert.AreEqual(6, collection[collection.Count - 1]);
        }

        [Test]
        public void Test_Collections_InsertAtInvalidIndex()
        {
            // Arrange
            var collection = new Collection<int>(new int[] { 1, 2, 3, 4, 5 });

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => collection.InsertAt(-1, 1));
        }

        [Test]
        public void Test_Collections_RemoveAtBegining()
        {
            // Arrange
            var collection = new Collection<int>(new int[] { 1, 2, 3, 4, 5 });

            // Act
            collection.RemoveAt(0);

            // Assert
            Assert.AreEqual(2, collection[0]);
        }

        [Test]
        public void Test_Collections_RemoveAtEnd()
        {
            // Arrange
            var collection = new Collection<int>(new int[] { 1, 2, 3, 4, 5 });

            // Act
            collection.RemoveAt(collection.Count - 1);

            // Assert
            Assert.AreEqual(4, collection.Count);
        }

        [Test]
        public void Test_Collections_SetByIndex()
        {
            // Arrange
            var collection = new Collection<int>(new int[] { 1, 2, 3, 4, 5 });

            // Act
            collection[0] = 0;

            // Assert
            Assert.AreEqual(0, collection[0]);
        }

        [Test]
        public void Test_Collections_ToString()
        {
            // Arrange
            var collection = new Collection<int>(new int[] { 1, 2, 3, 4, 5 });

            // Act
            string collectionString = collection.ToString();

            // Assert
            Assert.AreEqual("[1, 2, 3, 4, 5]", collectionString);
        }
    }
}