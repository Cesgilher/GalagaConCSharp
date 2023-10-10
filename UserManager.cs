using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalagaConC_
{
    public class UserManager
    {
        List<User> users = new List<User>();
        private string path = @"C:\Users\cehernando\Desktop\userTable.txt";

        public List<User> ReadUserFile()
        {             
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

                            if (parts.Length == 4)
                            {
                                User u = new User(parts[0], Convert.ToInt16(parts[1]), parts[2], parts[3]);
                                users.Add(u);
                            }
                            else
                            {
                                Console.WriteLine($"Error en línea: {line}. Datos incompletos.");
                            }
                        }
                    }

                    return users;
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
        public void SafeToUserFile() 
        {
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) { }
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    
                    foreach (User user in users)
                    {
                        sw.WriteLine($"{user.Name} {user.PhoneNumber} {user.Email} {user.Password}");
                    }
                }


            }




            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar los datos en el archivo: {ex.Message}");

            }

        }

        public User Register(User user)
        {
            User session = null;
            
            if (users != null)
            { 
                bool userExists = users.Any(u => u.Email == user.Email);

                if (userExists)
                {
                    Console.WriteLine("Ese usuario ya existe");
                }
                else
                {
                    users.Add(user);
                    session = user;
                    Console.WriteLine("Usuario registrado con éxito.");

                }

                
            }
            return session;


        }
        public User EditName(User session, string newName) 
        {
          
            bool usernameExists = users.Any(u => u.Name == newName);
            if (!usernameExists)
            {
                int index = users.FindIndex(u => u.Email == session.Email);

                if (index != -1)
                {
                    users[index].Name = newName;
                }

                session.Name = newName;

            }
            else
            {
                Console.WriteLine("Ese nombre de usuario no está disponible");
            }
            return session;
        }
        public User EditPhone(User session, int newPhone) 
        {
            bool phoneExists = users.Any(u => u.PhoneNumber == newPhone);
            if (!phoneExists)
            {
                int index = users.FindIndex(u => u.Email == session.Email);

                if (index != -1)
                {
                    users[index].PhoneNumber = newPhone;
                }

                session.PhoneNumber = newPhone;

            }
            else
            {
                Console.WriteLine("Ese numero ya está asignado a otra cuenta");
            }
            return session;

        }
        public User EditPassword(User session, string newPassword)
        {
            if (session.Password != newPassword)
            {
                int index = users.FindIndex(u => u.Email == session.Email);

                if (index != -1)
                {
                    users[index].Password = newPassword;
                }

                session.Password = newPassword;

            }
            else
            {
                Console.WriteLine("Esa contraseña es identica a la actual");
            }
            return session;

        }
        public User LogIn(User user)
        {
            User session = null;
            if (users != null)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (user.Email== users[i].Email && user.Password == users[i].Password)
                    {
                        session = users[i];
                        Console.WriteLine("Se ha iniciado sesion correctamente");
                        break;
                    }
                    else if (user.Email == users[i].Email)
                    {
                        Console.WriteLine("Contraseña incorrecta");

                    }
                    

                }
            }
            return session;
        }
        public User LogOut(User session) 
        {
            session = null;
            return session;
        }
        public User Delete(User session) 
        {

            if (users != null) 
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (session.Email == users[i].Email)
                    {
                        users.RemoveAt(i);
                        session = null;
                        break;
                    }
                    

                }
            }
            return session;


        }


    }

}
