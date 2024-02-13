namespace prototype;

public class Data
{
    public double Value { get; set; }
    public string Field { get; set; }

    public Data(string field, double value)
    {
        this.Field = field;
        this.Value = value;
    }
    
}