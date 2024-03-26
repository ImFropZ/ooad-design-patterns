public class EvenState : IState
{
    public void Handle(Context ctx)
    {
        if (ctx.GetCount() % 2 == 0) ctx.SetState(this);
        else ctx.SetState(new OddState());
    }

    public string GetCurrentStateName()
    {
        return "Even";
    }
}