using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Concrete handler for handling medium priority tickets.
    /// </summary>
    public class MediumPriorityHandler : AbstractHandler
    {
        /// <summary>
        /// Handles the ticket with medium priority.
        /// </summary>
        /// <param name="ticket">The ticket to handle.</param>
        public override void Handle(Ticket ticket)
        {
            if (ticket.Priority == Priority.Medium)
                Console.WriteLine("Medium priority handler is handling the ticket: " + ticket.Content);
            else
                base.Handle(ticket);
        }
    }
}