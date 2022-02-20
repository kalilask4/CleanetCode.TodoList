namespace CleanetCode.TodoList.CLI.Operations;

public interface IOperation
{
    string Name { get; }
    void Execute();
}