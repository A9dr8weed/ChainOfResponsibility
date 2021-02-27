using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// A concrete Handler class.
    /// </summary>
    public class PurchasingManager : Approver
    {
        public override void Handle(PurchaseOrder purchase)
        {
            if (purchase.Price < 2500)
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