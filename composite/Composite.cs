namespace composite;

public class Composite : IComponent
{
    private List<IComponent> list; 
    
    public Composite(IComponent[] components)
    {
        list = new List<IComponent>(components);
    }
    
    public string Operation()
    {
        if (list == null || list.Count == 0)
        {
            throw new Exception("No component");
        }

        String tmp = "";
        foreach (var component in list)
        {
            if (tmp.Equals(""))
                tmp = "[";
            else
                tmp += ", ";
            tmp += component.Operation();
        }
        
        tmp += "]";
        return tmp;
    }
}