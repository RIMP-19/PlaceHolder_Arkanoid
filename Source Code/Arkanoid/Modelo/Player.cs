namespace Arkanoid.Modelo
{
    public class Player
    {
        public string UserName { get; set; }
        public int Score { get; set; }

        public Player()
        {
            UserName = "UNKNOWN";
            Score = 0;
        }
    }
}
