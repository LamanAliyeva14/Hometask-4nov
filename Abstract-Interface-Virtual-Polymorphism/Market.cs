using System;
namespace Abstract_Interface_Virtual_Polymorphism
{
	public class Market:Istore
	{
		public Market()
		{
		}

        public string Products { get; set; }
        public int ProductLimit { get; set; }
        public decimal TotalIncome { get; set; }

        public void AddProduct(Product product)
        {
            
        }

        public void SellProduct(string productName)
        {
            ;
        }
    }
}

