namespace Abstract_Interface_Virtual_Polymorphism
{
    public interface Istore
	{
		string Products { get; set; }
        int ProductLimit { get; set; }
		decimal TotalIncome { get; set; }

		void AddProduct(Product product);

		void SellProduct(string productName); 
	}

}

