
using System;

namespace EventDemo
{
    // Step 1: Define a delegate
    public delegate void SomeEventHandler(object sender, EventArgs e);

    // Publisher class
    class Publisher
    {
        // Step 2: Declare the event
        public event SomeEventHandler SomeEvent;

        // Method to raise the event
        public void NotifyAboutEvent(EventArgs e)
        {
            // Step 3: Raise/Invoke the event
            if (SomeEvent != null) // Check if there are any subscribers
            {
                SomeEvent(this, e); // Raise/Invoke the event
            }
        }

        // Method to simulate an action that triggers the event
        public void DoSomething()
        {
            Console.WriteLine("Publisher is doing something...");
            // Raise the event when the action occurs
            NotifyAboutEvent(EventArgs.Empty);
        }
    }

    // Subscriber class
    class Subscriber
    {
        // Event handler method
        public void HandleSomeEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event received by Subscriber.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisherObject = new();
            Subscriber subscriberObject = new();

            // subscriberObject subscribes to SomeEvent
            // which is declared in publisherObject's class
            // by using '+=' operator
            publisherObject.SomeEvent += subscriberObject.HandleSomeEvent;

            // Trigger the action to raise event in the publisher
            publisherObject.DoSomething();
        }
    }
}
