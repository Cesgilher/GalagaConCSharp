using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalagaConC_.Controller;
using GalagaConC_.Models;

public class Program
{
    public static void Main()
    {
        UserManager uManager = new();
        uManager.GetUsers();
        User user = new("cesar2", "cesar");
        User user2 = new("cesar3", "cesar");
        User user3 = new("cesar4", "cesar");
        User user4 = new("cesar5", "cesar");
        User user5 = new("cesar6", "cesar");
        User user6 = new("cesar7", "cesar");
        uManager.Register(user);
        uManager.Register(user2);
        uManager.Register(user3);
        uManager.Register(user4);
        uManager.Register(user5);
        uManager.Register(user6);
        uManager.SafeToUserFile();

        

    }

}