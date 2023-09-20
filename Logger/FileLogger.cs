namespace Logger;

public class FileLogger : ILogger
{
    private readonly string _info;
    private readonly string _error;
    private readonly string _warning;
    private readonly string _success;
    private readonly string  _custom;
    
    public FileHelper FileHelper { get; set; }
    
    public FileLogger(string info, string error, string warning, string success, string custom)
    {
        _info = info;
        _error = error;
        _warning = warning;
        _success = success;
        _custom = custom;

        FileHelper = new FileHelper();
    }

    public FileLogger()
    {
        _info = "info.log";
        _error = "error.log";
        _warning = "warning.log";
        _success = "success.log";
        _custom = "custom.log";
        
        FileHelper = new FileHelper();
    }
    
    
    public void Info(string message)
    {
        FileHelper.WriteToFile(_info, $"{DateTime.Now} [{nameof(Info).ToUpper()}] {message}");
    }

    public void Error(string message)
    {
        FileHelper.WriteToFile(_error, $"{DateTime.Now} [{nameof(Error).ToUpper()}] {message}");
    }

    public void Warning(string message)
    {
        FileHelper.WriteToFile(_warning, $"{DateTime.Now} [{nameof(Warning).ToUpper()}] {message}");
    }

    public void Success(string message)
    {
        FileHelper.WriteToFile(_success, $"{DateTime.Now} [{nameof(Success).ToUpper()}] {message}");
    }

    public void Custom(string type, string message)
    {
        FileHelper.WriteToFile(_custom, $"{DateTime.Now} [{nameof(Custom).ToUpper()}] {message}");
    }
    
}