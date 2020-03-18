namespace RPG
{
    public interface Fight
    {

        public void fight(int PlayerHP, int RivalHP, int PlayerDP, int RivalDP, int playerStrength, int RivalStrength,
            int playerDodge, int rivalDodge)
        {
            PlayerHP = PlayerHP +  PlayerDP / 2;
            RivalHP = RivalHP + RivalDP / 2;

            while (PlayerHP >= 0 && RivalHP >= 0)
            {
                RivalHP = RivalHP - playerStrength;
                PlayerHP = PlayerHP - RivalStrength;
                
            }
        }
    }
}