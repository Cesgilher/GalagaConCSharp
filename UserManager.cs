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


        public List<User> ReadUserTable()
        {
            string path = @"C:\Users\cehernando\Desktop\userTable.txt";
            
            List<User> listOfUsers = new List<User>();

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
                                listOfUsers.Add(u);
                            }
                            else
                            {
                                Console.WriteLine($"Error en línea: {line}. Datos incompletos.");
                            }
                        }
                    }

                    return listOfUsers;
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
        public User Register(User user)
        {
            User session = null;
            string path = "C:\\Users\\cehernando\\Desktop\\userTable.txt";
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path));
            }
            List<User> existingUsers = ReadUserTable();
            if (existingUsers != null)
            { 
                bool userExists = existingUsers.Any(u => u.Email == user.Email);

                if (userExists)
                {
                    Console.WriteLine("Ese usuario ya existe");
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        // Escribir el nuevo usuario en una nueva línea del archivo
                        sw.WriteLine($"{user.Name} {user.PhoneNumber} {user.Email} {user.Password}");
                    }

                    Console.WriteLine("Usuario registrado con éxito.");
                    session = user;
                }

                
            }
            return session;


        }
        public User Edit(User session) 
        {
            List<User> existingUsers = ReadUserTable();
            Console.WriteLine("que quiere cambiar");
            Console.WriteLine("1) nombre de usuario");
            Console.WriteLine("2) telefono");
            Console.WriteLine("3) contraseña");
            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("introduzca el nuevo nombre de usuario");
                    string userName = Console.ReadLine();
                    bool usernameExists = existingUsers.Any(u => u.Name == userName);
                    if (!usernameExists)
                    {
                        session.Name = userName;

                    }
                    else
                    {
                        Console.WriteLine("Ese nombre de usuario no está disponible");
                    }


                    break;

                case 2:
                    Console.WriteLine("introduzca el nuevo numero de telefono");
                    string userPhone = Console.ReadLine();
                    bool userPhoneExists = existingUsers.Any(u => u.Name == user);
                    if (!usernameExists)
                    {
                        session.Name = username;

                    }
                    else
                    {
                        Console.WriteLine("Ese nombre de usuario no está disponible");
                    }

                case 3:
                    break;
            }
            if (existingUsers != null)
            {
                for (int i = 0; i < existingUsers.Count; i++)
                {
                    if (session.Email == existingUsers[i].Email)
                    {
                        existingUsers.RemoveAt(i);
                        using (StreamWriter sw = new StreamWriter(path, false))
                        {
                            foreach (User user in existingUsers)
                            {
                                sw.WriteLine($"{user.Name} {user.PhoneNumber} {user.Email} {user.Password}");


                            }
                        }
                        session = null;
                        break;
                    }


                }
            }

            return session;
        }



        public User LogIn(User user)
        {
            User session = null;
            List<User> existingUsers = ReadUserTable();
            if (existingUsers != null)
            {
                for (int i = 0; i < existingUsers.Count; i++)
                {
                    if (user.Email== existingUsers[i].Email && user.Password == existingUsers[i].Password)
                    {
                        session = existingUsers[i];
                        Console.WriteLine("Se ha iniciado sesion correctamente");
                        break;
                    }
                    else if (user.Email == existingUsers[i].Email)
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
            string path = "C:\\Users\\cehernando\\Desktop\\userTable.txt";

            List<User> existingUsers = ReadUserTable();
            if (existingUsers != null) 
            {
                for (int i = 0; i < existingUsers.Count; i++)
                {
                    if (session.Email == existingUsers[i].Email)
                    {
                        existingUsers.RemoveAt(i);
                        using (StreamWriter sw = new StreamWriter(path, false))
                        {
                            foreach(User user in existingUsers)
                            {
                                sw.WriteLine($"{user.Name} {user.PhoneNumber} {user.Email} {user.Password}");


                            }
                        }
                        session = null;
                        break;
                    }
                    

                }
            }
            return session;


        }
    }
}
