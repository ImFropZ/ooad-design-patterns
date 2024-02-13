namespace prototype;

public class SimplePrototype : IPrototype
{
    private Data data = null;

    public int Number { get; set; }

    public Data Data
    {
        get { return this.data; }
    }

    public SimplePrototype(int number, Data data)
    {
        this.Number = number;
        this.data = data;
    }

    public IPrototype Clone()
    {
        return new SimplePrototype(this.Number, this.data);
    }

    public string Info
    {
        get { return $"Number: {this.Number}, Data: {this.data.Field} - {this.data.Value}"; }
    }
}