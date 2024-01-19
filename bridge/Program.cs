interface IMethod
{
    float Amount { get; set; }
    float Discount { get; set; }
    float Vat { get; set; }
    float ServiceCharge { get; set; }

    void Calculate();
}

class BaseOnAmount : IMethod
{
    public float Amount { get; set; } = 0;
    public float Discount { get; set; } = 1;
    public float Vat { get; set; } = 1;
    public float ServiceCharge { get; set; } = 1;

    public void Calculate()
    {
        Console.WriteLine("Grand Total:{0}",
            Amount - Amount * (Discount / 100) + Amount * (Vat / 100) + Amount * (ServiceCharge / 100));
    }
}

class BaseOnCalculation : IMethod
{
    public float Amount { get; set; } = 0;
    public float Discount { get; set; } = 1;
    public float Vat { get; set; } = 1;
    public float ServiceCharge { get; set; } = 1;

    public void Calculate()
    {
        var afterDiscount = Amount - Amount * (Discount / 100);
        var afterVat = afterDiscount + afterDiscount * (Vat / 100);
        var afterServiceCharge = afterVat + afterVat * (ServiceCharge / 100);

        Console.WriteLine("Grand Total:{0}", afterServiceCharge);
    }
}

class Payment
{
    public IMethod Method { get; set; }

    public Payment(IMethod method)
    {
        Method = method;
    }

    public void GrandTotal()
    {
        Method.Calculate();
    }
}

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