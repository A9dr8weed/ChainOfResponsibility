using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// The details of the purchase request.
    /// </summary>
    public class PurchaseOrder
    {
        /// <summary>
        /// Request number.
        /// </summary>
        public int RequestNumber { get; set; }

        /// <summary>
        /// Amount of purchase.
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Purchase price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Purchase name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="number"> Number. </param>
        /// <param name="amount"> Amount. </param>
        /// <param name="price"> Price. </param>
        /// <param name="name"> Name. </param>
        public PurchaseOrder(int number, double amount, double price, string name)
        {
            RequestNumber = number;
            Amount = amount;
            Price = price;
            Name = name;

            Console.WriteLine($"Purchase request for {name} ({amount} for ${price}) has been submitted.");
        }
    }
}