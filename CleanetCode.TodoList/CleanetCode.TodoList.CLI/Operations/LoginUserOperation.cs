namespace CleanetCode.TodoList.CLI.Operations;

public partial class LoginUserOperation: IOperation
{
    public string Name => "Login into the system";

    public void Execute()
    {
        Console.WriteLine("User logged in");
    }
}