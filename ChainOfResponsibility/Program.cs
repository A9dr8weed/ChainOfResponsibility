using System;

namespace ChainOfResponsibility
{
    public static class Program
    {
        private static void Main()
        {
            // Create the chain links.
            Approver jennifer = new HeadChef();
            Approver mitchell = new PurchasingManager();
            Approver olivia = new GeneralManager();

            // Create the chain.
            jennifer.SetNext(mitchell).SetNext(olivia);

            // Generate and process purchase requests.
            PurchaseOrder p = new PurchaseOrder(3, 20, 10, "Spices");
            jennifer.Handle(p);

            Console.WriteLine();

            // Skip first chain.
            p = new PurchaseOrder(2, 300, 1389, "Fresh Veggies");
            jennifer.Handle(p);

            Console.WriteLine();

            // Skip first and second chain.
            p = new PurchaseOrder(1, 500, 4823.99, "Beef");
            jennifer.Handle(p);

            Console.WriteLine();

            // Was left untouched.
            p = new PurchaseOrder(4, 4, 12099, "Ovens");
            jennifer.Handle(p);
        }
    }
}