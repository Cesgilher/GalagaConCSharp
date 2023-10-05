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

        User user = new("juan",112,"juan1@gmail.com","passwd");

        uManager.Register(user);
    }

}