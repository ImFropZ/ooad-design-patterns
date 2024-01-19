namespace bridge.bridge;

public interface IMethod
{
    float Amount { get; set; }
    float Discount { get; set; }
    float Vat { get; set; }
    float ServiceCharge { get; set; }

    void Calculate();
}