public class Context
{
    private int _count = 0;
    private Dictionary<string, IStrategy> _strategies = new();

    public Context()
    {
        _strategies.Add("A", new StrategyA());
        _strategies.Add("B", new StrategyB());
    }

    // Will pick either strategy A or B depend on even of _count
    public void GetResult()
    {
        _count++;
        if (_count % 2 == 0)
        {
            var isSucceed = _strategies.TryGetValue("A", out var strategy);
            if (!isSucceed || strategy == null)
                return;
            strategy.Action();
        }
        else
        {
            var isSucceed = _strategies.TryGetValue("B", out var strategy);
            if (!isSucceed || strategy == null)
                return;
            strategy.Action();
        }
    }
}