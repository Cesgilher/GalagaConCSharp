using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalagaConC_;

public class Program
{
    public static void Main()
    {
        UserManager uManager = new();

        User user = new("juan1@gmail.com","passwd");

        User session = uManager.LogIn(user);
        uManager.Delete(session);

    }

}