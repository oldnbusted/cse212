using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following items and priority: Vase (1), Shoe (3), Car (0), Dark (2)
    // Dequeue 4 times.
    // Expected Result: Shoe, Dark, Vase, Car
    // Defect(s) Found: Assert.AreEqual failed. Expected:<Dark>. Actual:<Shoe>.
    // Fixed PriorityQueue.Dequeue: Passed
    public void TestPriorityQueue_DifferentPriorities()
    {
        string[] expectedResult = ["Shoe", "Dark", "Vase", "Car"];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Vase", 1);
        priorityQueue.Enqueue("Shoe", 3);
        priorityQueue.Enqueue("Car", 0);
        priorityQueue.Enqueue("Dark", 2);

        for (int i = 0; i < 4; i++)
        {
            Assert.AreEqual(expectedResult[i], priorityQueue.Dequeue());
        }
        
    
    }

    [TestMethod]
    // Scenario: Create a queue with the following items and priorities Vase (1), Shoe (3), Car (0), Dark (2), Fork (1)
    // Dequeue 5 times.
    // Expected Result: Shoe, Dark, Vase, Fork, Car
    // Defect(s) Found: Assert.AreEqual failed. Expected:<Dark>. Actual:<Shoe>.
    // Fixed PriorityQueue.Dequeue: Assert.AreEqual failed. Expected:<Vase>. Actual:<Fork>.
    // Fixed PriorityQueue.Dequeue: Assert.AreEqual failed. Expected:<Car>. Actual:<Fork>.
    // Fixed test expectedResult: Pass

    public void TestPriorityQueue_SamePriority()
    {
  string[] expectedResult = ["Shoe", "Dark", "Vase", "Fork", "Car"];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Vase", 1);
        priorityQueue.Enqueue("Shoe", 3);
        priorityQueue.Enqueue("Car", 0);
        priorityQueue.Enqueue("Dark", 2);
        priorityQueue.Enqueue("Fork", 1);

        for (int i = 0; i < 5; i++)
        {
            Assert.AreEqual(expectedResult[i], priorityQueue.Dequeue());
        }
        
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Try to get an item from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found:
    public void TestPriorityQueue_empty()
    {
        var items = new PriorityQueue();

        try
        {
            items.Dequeue();
            Assert.Fail("Excepton should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                string.Format("Unexpected exception of type {0} caught: {1}",
                    e.GetType(), e.Message)
            );
        }
    }
}