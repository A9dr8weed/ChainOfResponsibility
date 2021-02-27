using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// A concrete Handler class.
    /// </summary>
    public class GeneralManager : Approver
    {
        public override void Handle(PurchaseOrder purchase)
        {
            if (purchase.Price < 10000)
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