using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalagaConC_.Models;

namespace GalagaConC_.Controller
{
    public class UserManager
    {
        List<User> users = new List<User>();
        private string path = @"..\..\..\DB\\userTable.txt";

        public List<User> GetUsers()
        {
            //DBContext.GetAll(User)
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

        public User EditField<T>(User session, T newValue, Func<User, T> getField, Action<User, T> setField, string errorMessage)
        {
            bool fieldExists = users.Any(u => getField(u).Equals(newValue));

            if (!fieldExists)
            {
                int index = users.FindIndex(u => u.Email == session.Email);

                if (index != -1)
                {
                    setField(users[index], newValue);
                }

                setField(session, newValue);
            }
            else
            {
                Console.WriteLine(errorMessage);
            }

            return session;
        }

        public User EditName(User session, string newName)
        {
            return EditField(session, newName, u => u.Name, (u, value) => u.Name = value, "Ese nombre de usuario no está disponible");
        }

        public User EditPhone(User session, int newPhone)
        {
            return EditField(session, newPhone, u => u.PhoneNumber, (u, value) => u.PhoneNumber = value, "Ese número ya está asignado a otra cuenta");
        }

        public User EditPassword(User session, string newPassword)
        {
            return EditField(session, newPassword, u => u.Password, (u, value) => u.Password = value, "Esa contraseña es idéntica a la actual");
        }

        public User LogIn(User user)
        {
            User session = null;
            if (users != null)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (user.Email == users[i].Email && user.Password == users[i].Password)
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
