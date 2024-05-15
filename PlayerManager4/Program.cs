using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class Program
    {
        private static void Main() //Model created
        {
            // Initialize the player list with two players using collection
            // initialization syntax
                List<Player> playerList = new List<Player>()
                {
                new Player("Ana", 100),
                new Player("Bruno", 500)
                };

            Controller controller = new Controller(playerList);

            IView view = new UglyView(controller, playerList);

            //Start the Controller instance
            controller.Start(view);
        }
    }
}