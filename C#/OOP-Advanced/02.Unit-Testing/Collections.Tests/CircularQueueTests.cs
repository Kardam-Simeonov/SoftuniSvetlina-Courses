using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    public class CircularQueueTests
    {
        [Test]
        public void Test_CircularQueue_ConstructorDefault()
        {
            // Arrange
            var queue = new CircularQueue<int>();

            //Assert
            Assert.That(queue.ToString() == "[]");
            Assert.That(queue.Count == 0);
            Assert.That(queue.Capacity > 0);
            Assert.That(queue.StartIndex == 0);
            Assert.That(queue.EndIndex == 0);
        }

        [Test]
        public void Test_CircularQueue_ConstructorWithCapacity()
        {
            // Arrange
            var queue = new CircularQueue<int>(10);

            //Assert
            Assert.That(queue.ToString() == "[]");
            Assert.That(queue.Count == 0);
            Assert.That(queue.Capacity > 0);
            Assert.That(queue.StartIndex == 0);
            Assert.That(queue.EndIndex == 0);
        }

        [Test]
        public void Test_CircularQueue_Enqueue()
        {
            // Arrange
            var queue = new CircularQueue<int>();

            //Act
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            //Assert
            Assert.That(queue.ToString() == "[10, 20, 30]");
            Assert.That(queue.Count == 3);
            Assert.That(queue.Capacity >= queue.Count);
        }

        [Test]
        public void Test_CircularQueue_EnqueueWithGrow()
        {
            // Arrange
            var queue = new CircularQueue<int>();

            //Act
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Enqueue(60);
            queue.Enqueue(70);
            queue.Enqueue(80);
            queue.Enqueue(90);

            //Assert
            Assert.That(queue.ToString() == "[10, 20, 30, 40, 50, 60, 70, 80, 90]");
            Assert.That(queue.Count == 9);
            Assert.That(queue.Capacity >= queue.Count);
        }

        [Test]
        public void Test_CircularQueue_Dequeue()
        {
            // Arrange
            var queue = new CircularQueue<int>();

            //Act
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Dequeue();

            //Assert
            Assert.That(queue.ToString() == "[20, 30]");
            Assert.That(queue.Count == 2);
            Assert.That(queue.Capacity >= queue.Count);
        }

        [Test]
        public void Test_CircularQueue_DequeueEmpty()
        {
            // Arrange
            var queue = new CircularQueue<int>();

            //Assert
            Assert.That(queue.ToString() == "[]");
            Assert.That(queue.Count == 0);
            Assert.That(queue.Capacity >= queue.Count);
            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }

        [Test]
        public void Test_CircularQueue_PeekEmpty()
        {
            // Arrange
            var queue = new CircularQueue<int>();

            //Assert
            Assert.Throws<InvalidOperationException>(() => queue.Peek());
        }

        [Test]
        public void Test_CircularQueue_ToArray()
        {
            //Arrange
            var queue = new CircularQueue<int>();

            //Act
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            var array = queue.ToArray();

            //Assert
            CollectionAssert.AreEqual(new int[] { 10, 20, 30 }, array);
        }

        [Test]
        public void Test_CircularQueue_EnqueueDequeue_WithRangeCross()
        {
            var queue = new CircularQueue<int>(5);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            var firstElement = queue.Dequeue();
            Assert.AreEqual(firstElement, 10);

            var secondElement = queue.Dequeue();
            Assert.AreEqual(secondElement, 20);

            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Enqueue(60);

            Assert.That(queue.ToString() == "[30, 40, 50, 60]");
            Assert.That(queue.Count == 4);
            Assert.That(queue.Capacity == 5);
            Assert.That(queue.StartIndex > queue.EndIndex);
        }

        [Test]
        public void Test_CircularQueue_MultipleOperations()
        {
            const int initialCapacity = 2;
            const int iterationsCount = 300;

            var queue = new CircularQueue<int>(initialCapacity);
            int addedCount = 0;
            int removedCount = 0;
            int counter = 0;

            for (int i = 0; i < iterationsCount; i++)
            {
                Assert.That(queue.Count == addedCount - removedCount);

                queue.Enqueue(++counter);
                addedCount++;
                Assert.That(queue.Count == addedCount - removedCount);

                queue.Enqueue(++counter);
                addedCount++;
                Assert.That(queue.Count == addedCount - removedCount);

                var firstElement = queue.Peek();
                Assert.That(firstElement == removedCount + 1);

                var removedElement = queue.Dequeue();
                removedCount++;
                Assert.That(removedElement == removedCount);
                Assert.That(queue.Count == addedCount - removedCount);

                var expectedElements = Enumerable.Range(
                    removedCount + 1, addedCount - removedCount).ToArray();
                var expectedString = "[" + string.Join(", ", expectedElements) + "]";

                var queueAsArray = queue.ToArray();
                var queueAsString = queue.ToString();

                CollectionAssert.AreEqual(expectedElements, queueAsArray);
                Assert.AreEqual(expectedString, queueAsString);

                Assert.That(queue.Capacity >= queue.Count);
            }

            Assert.That(queue.Capacity > initialCapacity);
        }

        [Test]
        public void Test_CircularQueue_1MillionItems()
        {
            const int iterationsCount = 10000000;
            var queue = new CircularQueue<int>();
            int addedCount = 0;
            int removedCount = 0;
            int counter = 0;

            for (int i = 0; i < iterationsCount; i++)
            {
                queue.Enqueue(++counter);
                addedCount++;

                queue.Enqueue(++counter);
                addedCount++;

                queue.Dequeue();
                removedCount++;
            }

            Assert.That(queue.Count == addedCount - removedCount);
        }
    }
}
