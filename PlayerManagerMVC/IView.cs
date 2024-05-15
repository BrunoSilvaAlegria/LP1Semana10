using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public interface IView 
    {
        int MainMenu();

        void EndMessage();

        void InvalidOption();

        void AfterMenu();

        Player InsertPlayer();

        void ListPlayers(IEnumerable<Player> playersToList);

        int AskMinimumScore();

        PlayerOrder AskForPlayerOrder();
    }
}