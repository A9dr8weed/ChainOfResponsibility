using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// A concrete Handler class.
    /// </summary>
    public class HeadChef : Approver
    {
        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="purchase"> The query data being checked. </param>
        public override void Handle(PurchaseOrder purchase)
        {
            if (purchase.Price < 1000)
            {
                Console.WriteLine($"{GetType().Name} approved purchase request #{purchase.RequestNumber}");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} {purchase.Name} was left untouched #{purchase.RequestNumber}");
                base.Handle(purchase);
            }
        }
    }
}