namespace Logger;

public class FileHelper
{
    public event Action<string>? ExceptoinHandler; 
    
    public void WriteToFile(string path, string message)
    {
        try
        {
            var file = new StreamWriter(path, append: true);
            file.WriteLine(message);
            file.Close();
        }
        catch (ArgumentException)
        {
            OnExceptoinHandler("Неверно указан путь к файлу");
        }
        catch (DirectoryNotFoundException)
        {
            OnExceptoinHandler("Указан недопустимый путь");
        }
        catch (IOException) 
        {
            OnExceptoinHandler("Параметр PATH включает неверный синтаксис");
        }
        catch (Exception)
        {
            OnExceptoinHandler("Неизвестная ошибка");
        }
    }
    
    private void OnExceptoinHandler(string obj)
    {
        ExceptoinHandler?.Invoke(obj);
    }
}