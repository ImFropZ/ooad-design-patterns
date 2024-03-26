public class OddState : IState
{
    public void Handle(Context ctx)
    {
        if (ctx.GetCount() % 2 == 1) ctx.SetState(this);
        else ctx.SetState(new EvenState());
    }

    public string GetCurrentStateName()
    {
        return "Odd";
    }
}