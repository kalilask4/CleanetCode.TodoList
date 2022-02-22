using CleanetCode.TodoList.CLI.Operations;

IOperation[] operations = new IOperation[]
{
    new LoginUserOperation(),
    new CreateNewUserOperation()
};

foreach (var operation in operations)
{
    operation.Execute();

    if (operation is LoginUserOperation)
    {
        operation.Execute(); 
    }
}
