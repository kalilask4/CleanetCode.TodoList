using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;
using Microsoft.VisualBasic.CompilerServices;

namespace CleanetCode.TodoList.CLI.Operations;

public class CreateNewUserOperation: IOperation
{
    public string Name => "Create new user";


    public void Execute()
    {
        Console.Write("Введите ваш email: "); //на домашку - проверка валидности email
        string? email = Console.ReadLine();
        User newUser = new User
        {
            Email = email
        };

        bool userCreated = UserStorage.Create(newUser);
        if (!userCreated)
        {
            Console.WriteLine("User with this email is exist."); //на домашку - доработать список ошибок
        }

        UserStorage.Create(newUser);
        Console.WriteLine("User created");
    }
}