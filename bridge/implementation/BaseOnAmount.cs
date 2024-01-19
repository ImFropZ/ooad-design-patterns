using bridge.bridge;

namespace bridge.implementation;

public class BaseOnAmount: IMethod
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