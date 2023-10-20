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

                        if (filePath == FilePath.User)
                        {
                            if (parts.Length == 4)
                            {
                                User u = new User(parts[0], Convert.ToInt16(parts[1]), parts[2], parts[3]);
                                items.Add(u);
                            }
                            else
                            {
                                Console.WriteLine($"Error en línea: {line}. Datos incompletos.");
                            }
                            
                        }
                        else if (filePath == FilePath.Score)
                        {
                            List<Score> scores = new List<Score>();

                            if (parts.Length == 3)
                            {
                                Score s = new Score(parts[0], Convert.ToInt16(parts[1]), Convert.ToInt16(parts[2]));
                                scores.Add(s);
                            }
                            else
                            {
                                Console.WriteLine($"Error en línea: {line}. Datos incompletos.");
                            }
                           

                        }

                    }
                }
                return items;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
                return null;
            }

        }
        else
        {
            return null;
        }



        
    }

}


public enum FilePath
{
    User,
    Score
}