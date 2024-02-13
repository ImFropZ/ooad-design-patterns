namespace prototype;

public class DeepPrototype : IPrototype
{
    private Data data = null;
    public int Number { get; set; }

    public Data Data
    {
        get { return this.data; }
    }

    public DeepPrototype(int num, Data dt)
    {
        this.Number = num;
        this.data = dt;
    }

    public string Info
    {
        get { return $"Number: {this.Number}, Data: {this.data.Field} - {this.data.Value}"; }
    }

    public IPrototype Clone()
    {
        return new DeepPrototype(Number,
            new Data(data.Field, data.Value));
    }
}