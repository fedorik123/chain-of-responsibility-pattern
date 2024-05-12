using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Entry point of the program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        static void Main(string[] args)
        {
            // Create handlers
            var highPriorityHandler = new HighPriorityHandler();
            var lowPriorityHandler = new LowPriorityHandler();
            var mediumPriorityHandler = new MediumPriorityHandler();

            // Set handler chain
            highPriorityHandler
                .SetNextHandler(mediumPriorityHandler)
                .SetNextHandler(lowPriorityHandler);

            // Create tickets
            var ticket1 = new Ticket("Fix login issue", Priority.Low);
            var ticket2 = new Ticket("Optimize database queries", Priority.Medium);
            var ticket3 = new Ticket("Critical server downtime", Priority.High);

            // Handle tickets
            highPriorityHandler.Handle(ticket1);
            highPriorityHandler.Handle(ticket2);
            highPriorityHandler.Handle(ticket3);

            Console.ReadLine();
        }
    }
}