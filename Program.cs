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
        User user = new("cesar", "cesar");
        uManager.GetUsers();
        uManager.Register(user);
        uManager.SafeToUserFile();

        

    }

}