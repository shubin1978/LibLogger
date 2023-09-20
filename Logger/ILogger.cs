﻿namespace Logger;

public interface ILogger
{
    public void Info(string message);
    public void Error(string message);
    public void Warning(string message);
    public void Success(string message);
    public void Custom(string type, string message);
}