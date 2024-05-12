namespace ChainOfResponsibility
{
    /// <summary>
    /// Represents a ticket with priority and content.
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Gets the content of the ticket.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets the priority of the ticket.
        /// </summary>
        public Priority Priority { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ticket"/> class with the specified content and priority.
        /// </summary>
        /// <param name="content">The content of the ticket.</param>
        /// <param name="priority">The priority of the ticket.</param>
        public Ticket(string content, Priority priority)
        {
            Content = content;
            Priority = priority;
        }
    }
}