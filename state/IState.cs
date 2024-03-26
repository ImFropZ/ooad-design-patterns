public interface IState
{
    void Handle(Context ctx);

    string GetCurrentStateName();
}