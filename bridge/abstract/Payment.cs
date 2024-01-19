using bridge.bridge;

namespace bridge.abstracts;

public class Payment
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