using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Concrete handler for handling low priority tickets.
    /// </summary>
    public class LowPriorityHandler : AbstractHandler
    {
        /// <summary>
        /// Handles the ticket with low priority.
        /// </summary>
        /// <param name="ticket">The ticket to handle.</param>
        public override void Handle(Ticket ticket)
        {
            if (ticket.Priority == Priority.Low)
                Console.WriteLine("Low priority handler is handling the ticket: " + ticket.Content);
            else
                base.Handle(ticket);
        }
    }

}