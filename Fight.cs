namespace RPG
{
    public interface Fight
    {

        public void fight(int playerHP, int rivalHP, int playerDP, int rivalDP, int playerStrength, int rivalStrength,
            int playerDodge, int rivalDodge)
        {
            playerHP = playerHP +  playerDP / 2;
            rivalHP = rivalHP + rivalDP / 2;
            
        }
    }
}