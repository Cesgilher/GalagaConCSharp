using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalagaConC_;
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

        Scoreboard scoreboard = new Scoreboard();
        scoreboard.GetType();
        scoreboard.GetScores();
        Score score = new("juan", 3, 1111);
        Score score2 = new("juan2", 88, 1111);
        Score score3 = new("juan3", 3, 2312321);
        Score score4 = new("juan4", 6, 1111423421);
        Score score5 = new("juan5", 4, 1111241234);
        scoreboard.AddScore(score);
        scoreboard.AddScore(score2);
        scoreboard.AddScore(score3);
        scoreboard.AddScore(score4);
        scoreboard.AddScore(score5);
        scoreboard.ListScores();
        scoreboard.SafeToScoreFile();



    }

}