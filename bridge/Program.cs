using bridge.abstracts;
using bridge.implementation;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=========== 1 ===========");
        var payment = new Payment(new BaseOnAmount())
        {
            Method =
            {
                Amount = 100,
                Discount = 20,
                Vat = 0,
                ServiceCharge = 0
            }
        };
        payment.GrandTotal();

        payment = new Payment(new BaseOnCalculation())
        {
            Method =
            {
                Amount = 100,
                Discount = 20,
                Vat = 0,
                ServiceCharge = 0
            }
        };
        payment.GrandTotal();
        
        Console.WriteLine("=========== 2 ===========");
        payment = new Payment(new BaseOnAmount())
        {
            Method =
            {
                Amount = 100,
                Discount = 0,
                Vat = 10,
                ServiceCharge = 0
            }
        };
        payment.GrandTotal();

        payment = new Payment(new BaseOnCalculation())
        {
            Method =
            {
                Amount = 100,
                Discount = 0,
                Vat = 10,
                ServiceCharge = 0
            }
        };
        payment.GrandTotal();
        
        Console.WriteLine("=========== 3 ===========");
        payment = new Payment(new BaseOnAmount())
        {
            Method =
            {
                Amount = 100,
                Discount = 20,
                Vat = 10,
                ServiceCharge = 0
            }
        };
        payment.GrandTotal();

        payment = new Payment(new BaseOnCalculation())
        {
            Method =
            {
                Amount = 100,
                Discount = 20,
                Vat = 10,
                ServiceCharge = 0
            }
        };
        payment.GrandTotal();
        
        Console.WriteLine("=========== 4 ===========");
        payment = new Payment(new BaseOnAmount())
        {
            Method =
            {
                Amount = 100,
                Discount = 20,
                Vat = 10,
                ServiceCharge = 5
            }
        };
        payment.GrandTotal();

        payment = new Payment(new BaseOnCalculation())
        {
            Method =
            {
                Amount = 100,
                Discount = 20,
                Vat = 10,
                ServiceCharge = 5
            }
        };
        payment.GrandTotal();

        Console.ReadKey();
    }
}