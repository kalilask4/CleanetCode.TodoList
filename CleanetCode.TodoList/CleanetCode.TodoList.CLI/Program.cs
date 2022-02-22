using CleanetCode.TodoList.CLI;
using CleanetCode.TodoList.CLI.Operations;

IOperation[] operations = new IOperation[]
{
    new LoginUserOperation(),
    new CreateNewUserOperation()
};
Menu menu = new Menu(operations);
Application application = new Application(menu);
application.Run();
