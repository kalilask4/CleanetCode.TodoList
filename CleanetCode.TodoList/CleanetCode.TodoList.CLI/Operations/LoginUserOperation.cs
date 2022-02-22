using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations;

public partial class LoginUserOperation: IOperation
{
    public string Name => "Login into the system";

    public void Execute()
    {
        Console.Write("Enter your email:");
        string email = Console.ReadLine();
        User? user = UserStorage.Get(email);

        if (user == null)
        {
            UserSession.CurrentUser = user;

        }
        

        Console.WriteLine("User logged in");
    }
}