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


        public void ReadUserTable()
        {
            string path = @"C:\Users\cehernando\Desktop\userTable.txt";

            if (File.Exists(path))
            {
                int lineCount = File.ReadLines(path).Count();

                User[] listOfUsers = new User[lineCount];

                using (StreamReader sr = File.OpenText(path))
                {

                    for (int i = 0; i < lineCount; i++)
                    {
                        string line = sr.ReadLine();
                        string[] parts = line.Split(' ');


                        if (parts.Length == 4)
                        {
                            User u = new User(parts[0], Convert.ToInt16(parts[1]), parts[2], parts[3]);

                            listOfUsers[i] = u;
                        }

                    }
                }

            }

            


        }
        public void Register(User user)
        {
            string path = "C:\\Users\\cehernando\\Desktop\\userTable.txt";

            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path));
                return;
            }

            using (StreamReader sr = File.OpenText(path))
            {

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] parts = line.Split(' ');


                    if (parts.Length == 4)
                    {
                        User u = new User(parts[0], Convert.ToInt16(parts[1]), parts[2], parts[3]);

                        if (user.Email != u.Email) 
                        
                        {
                        
                        }
                        ;
                    }

                }
            }








        }
        //public void Edit(User user){}
        //public void LogIn(User user) {}
        //public void LogOut(User user) { }
        //public void Delete(User user) { }
    }
}
