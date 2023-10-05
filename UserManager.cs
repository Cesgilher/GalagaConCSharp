﻿using System;
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
        public void Register(User user)
        {
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
                }

                
            }

            







        }
        //public void Edit(User user){}
        //public void LogIn(User user) {}
        //public void LogOut(User user) { }
        //public void Delete(User user) { }
    }
}
