using CleanetCode.TodoList.CLI.Operations;

namespace CleanetCode.TodoList.CLI;

public class Menu
{
    private IOperation[] _operations;

    public Menu(IOperation[] operations)
    {
        _operations = operations;
    }
}