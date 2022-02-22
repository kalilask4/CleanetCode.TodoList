namespace CleanetCode.TodoList.CLI.Operations;

public partial class LoginUserOperation: IOperation
{
    public string Name { get; }

    public void Execute()
    {
        Console.WriteLine("User logged in");
    }
}