using bridge.bridge;

namespace bridge.implementation;

public class BaseOnCalculation : IMethod
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