using System;
using System.Threading;

namespace RPG
{
    public interface IFight
    {
        public void fight(int PlayerHP, int RivalHP, int PlayerDP, int RivalDP, int PlayerStrength,
            int RivalStrength,
            int PlayerDodge, int RivalDodge, string PlayerName, string RivalName, int PlayerMoney);
    }
}
