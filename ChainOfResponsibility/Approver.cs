namespace ChainOfResponsibility
{
    /// <summary>
    /// The Handler abstract class. Every class which inherits from this will be responsible for a kind of request for the restaurant.
    /// </summary>
    public abstract class Approver : IHandler
    {
        /// <summary>
        /// Containing the component serves as the next link in the chain.
        /// </summary>
        private IHandler _nextHandler;

        /// <summary>
        /// Set next chain.
        /// </summary>
        /// <param name="handler"> Object. </param>
        /// <returns> Hendler. </returns>
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;

            // Returning a handler from here will let us link handlers in a
            // convenient way like this: obj.SetNext(obj1).SetNext(obj2);
            return handler;
        }

        /// <summary>
        /// The basic behavior of the components.
        /// And if not - redirect the request of each container, if one exists.
        /// </summary>
        /// <param name="request"> Object. </param>
        public virtual void Handle(PurchaseOrder request)
        {
            _nextHandler?.Handle(request);
        }
    }
}