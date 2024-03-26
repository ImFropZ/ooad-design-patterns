public class Context
{
    private int _count = 1;
    private IState _state = new OddState();

    public int GetCount()
    {
        return _count;
    }

    public void SetState(IState newState)
    {
        _state = newState;
    }

    public void CurrentState()
    {
        _count++;
        _state.Handle(this);
        Console.WriteLine(_state.GetCurrentStateName());
    }
}