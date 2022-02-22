namespace CleanetCode.TodoList.CLI;

public class Application
{
    private readonly Menu _menu;
    public Application(Menu meny)
    {
        _menu = meny;
    }

    public void Run()
    {
        string[] operationNames = _menu.GetOperationNames();
        Console.WriteLine(string.Join(", ", operationNames));
    }
}