using CleanetCode.TodoList.CLI.Operations;

namespace CleanetCode.TodoList.CLI;

public class Menu
{
    private IOperation[] _operations;

    public Menu(IOperation[] operations)
    {
        _operations = operations;
    }

    public string[] GetOperationNames()
    {
        List<string> operationNames = new List<string>();
        for (int i = 0; i < _operations.Length; i++)
        {
            IOperation operation = _operations[i];
            operationNames.Add($"{i} - {operation.Name}");
        }
        return operationNames.ToArray();
    }

    public void Enter(int operationNumber)
    {
        if (operationNumber < 0 || operationNumber >= _operations.Length)
        {
            return;
        }
        _operations[operationNumber].Execute();
    }
}