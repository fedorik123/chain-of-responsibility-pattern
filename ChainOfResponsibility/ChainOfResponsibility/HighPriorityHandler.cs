using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Concrete handler for handling high priority tickets.
    /// </summary>
    public class HighPriorityHandler : AbstractHandler
    {
        /// <summary>
        /// Handles the ticket with high priority.
        /// </summary>
        /// <param name="ticket">The ticket to handle.</param>
        public override void Handle(Ticket ticket)
        {
            if (ticket.Priority == Priority.High)
                Console.WriteLine("High priority handler is handling the ticket: " + ticket.Content);
            else
                base.Handle(ticket);
        }
    }

}