namespace ChatApp.Shared
{
    public class Player
    {
        // fields
        public string Username { get; set; }
        public int Points { get; set; } = 0;
        public List<Card>? Cards { get; set; }
        public int ValueOfCards { get; set; } = 0;
        public string LastAction { get; set; } = "Connected";

        // constructor
        public Player() { }

        public Player(string username, string lastAction)
        {
            this.Username = username;
            this.LastAction = lastAction;
        }
    }
}
