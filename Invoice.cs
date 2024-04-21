using System.Security.AccessControl;

class Invoice 
{
    public string Number { get; set; } 
    public string Description { get; set; }

    private int quantity;
    private decimal price;
    private decimal invoiceAmount; 
    
    //need a constructor now? 
    public Invoice(string partNumber, string partDescription, int partQuantity, decimal pricePerItem)
    {
        Number = partNumber;
        Description = partDescription;
        Quantity = partQuantity;
        Price = pricePerItem;
    }

    //for quantity and price, need get and set variables 
    
    public int Quantity
    {
        get
        {
            return quantity;
        }
        private set
        {
            if (value > 0)
            {
                quantity = value; 
            }
        }
    }
    public decimal Price
    {
        get
        {
            return price;
        }
        set
        {
            if (value > 0)
            {
                price = value;
            }
        }
    }

    // method to get invoice amount 
    public decimal GetInvoiceAmount() 
    { 
        return price * quantity; 
    }

}