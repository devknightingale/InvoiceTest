using System; 

class InvoiceTest
{
    static void Main()
    {
         
        Invoice myInvoice2 = new Invoice("23", "Test description", 34, 5.44m);

        
        // Testing the new constructor
        Console.WriteLine($"myInvoice2's information is:\nPart number: {myInvoice2.Number}\nDescription: {myInvoice2.Description}\nQuantity: {myInvoice2.Quantity}\nPrice per item: {myInvoice2.Price:C}");

        myInvoice2.Price = 5.55m;
        Console.WriteLine($"myInvoice2's new price is: {myInvoice2.Price:C}");

        Console.WriteLine($"Invoice amount is: {myInvoice2.GetInvoiceAmount():C}");
    }
  
}