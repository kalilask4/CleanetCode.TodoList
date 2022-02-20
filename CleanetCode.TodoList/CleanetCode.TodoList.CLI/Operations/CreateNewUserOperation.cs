using Microsoft.VisualBasic.CompilerServices;

namespace CleanetCode.TodoList.CLI.Operations;

public class CreateNewUserOperation: IOperation
{
    public string Name { get; }

    public void Execute()
    {
        Console.WriteLine("User created");
    }
}