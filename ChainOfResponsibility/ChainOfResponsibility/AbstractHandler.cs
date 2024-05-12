using System.Net.Sockets;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Abstract handler class for handling tickets.
    /// </summary>
    public abstract class AbstractHandler
    {
        protected AbstractHandler _nextHandler;

        /// <summary>
        /// Sets the next handler in the chain.
        /// </summary>
        /// <param name="handler">The next handler.</param>
        public AbstractHandler SetNextHandler(AbstractHandler handler)
        {
            _nextHandler = handler;

            return handler;
        }

        /// <summary>
        /// Handles the ticket.
        /// </summary>
        /// <param name="ticket">The ticket to handle.</param>
        public virtual void Handle(Ticket ticket)
        {
            if (_nextHandler != null)
                _nextHandler.Handle(ticket);
        }
    }

}
