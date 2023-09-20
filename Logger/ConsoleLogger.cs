namespace Logger;

public class ConsoleLogger : ILogger
{
    private void Print(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    public void Info(string message)
    {
       Print($"{DateTime.Now} [{nameof(Info).ToUpper()}] {message}", ConsoleColor.Blue);
    }

    public void Error(string message)
    { 
        Print($"{DateTime.Now} [{nameof(Error).ToUpper()}] {message}", ConsoleColor.Red);
    }

    public void Warning(string message)
    {
        Print($"{DateTime.Now} [{nameof(Warning).ToUpper()}] {message}", ConsoleColor.Yellow);
    }

    public void Success(string message)
    {
        Print($"{DateTime.Now} [{nameof(Success).ToUpper()}] {message}", ConsoleColor.Green);
    }

    public void Custom(string type, string message)
    {
        Print($"{DateTime.Now} [{type}] {message}", ConsoleColor.Magenta);
    }
}
