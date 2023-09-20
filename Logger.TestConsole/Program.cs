using Logger;

var logger = new ConsoleLogger();
logger.Info("Information");
logger.Error("Error");
logger.Warning("Warning");
logger.Success("Success");
logger.Custom("CUSTOM","Custom");

var fileLogger = new FileLogger("com1:", "com1:", "com1:", "com1:", "com1:");
fileLogger.FileHelper.ExceptoinHandler += msg => //+=logger.error;
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.WriteLine(msg);
    Console.ResetColor();
};
fileLogger.Info("Info");
fileLogger.Error("Info");
fileLogger.Warning("Info");
fileLogger.Success("Info");
fileLogger.Custom("custom","Info");