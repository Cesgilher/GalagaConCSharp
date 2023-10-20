using System;
using GalagaConC_.Models;
using System.IO;
using GalagaConC_;

public class DBContext<T> where T : class
{
	private readonly string userPath = @"..\..\..\DB\\userTable.txt";
    private readonly string scorePath = @"..\..\..\DB\\scoreTable.txt";

    public List<T> GetAll(FilePath filePath) 
    {
        List<T> items = new List<T>();
        string path;
        if (filePath == FilePath.User) { path = userPath; }
        else { path = scorePath; }

        if (File.Exists(path))
        {
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(' ');

                        if (typeof(T)==typeof(User) && parts.Length == 4)
                        {
                            T item = (T)Activator.CreateInstance(typeof(T),parts[0], Convert.ToInt16(parts[1]), parts[2], parts[3]);
                            items.Add(item);
                        }
                        else if (typeof(T)==typeof(Score) && parts.Length == 3)
                        {
                            T item = (T)Activator.CreateInstance(typeof(T), parts[0], Convert.ToInt16(parts[1]), parts[2]);
                            items.Add(item);
                        }
                        else
                        {
                                Console.WriteLine($"Error en línea: {line}. Datos incompletos.");
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");                
            }
        }
        return items;        
    }

    public void SaveAll(FilePath filePath, List<T> items)
    {
        string path;
        if (filePath == FilePath.User) { path = userPath; }
        else { path = scorePath; }

        try
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (T item in items) 
                {
                    string line;
                    if (typeof(T) == typeof(User))
                    {
                        User user = item as User;
                        line = $"{user.Name} {user.PhoneNumber} {user.Email} {user.Password}";
                    }
                    else if (typeof(T) == typeof(Score))
                    {
                        Score score = item as Score;
                        line = $"{score.User} {score.Level} {score.Points}";
                    }
                    else
                    {
                        // Handle other types if necessary
                        throw new InvalidOperationException("Tipo no compatible.");
                    }

                    sw.WriteLine(line);
                }
            }
        }
        catch( Exception ex ) { }
    }


public enum FilePath
{
    User,
    Score
}