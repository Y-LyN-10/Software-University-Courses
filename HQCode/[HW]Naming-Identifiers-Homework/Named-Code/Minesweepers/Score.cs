namespace Minesweepers
{
    public class Score
    {
        private string nickname;
        private int points;

        public Score()
        {
        }

        public Score(string nickname, int current)
        {
            this.Nickname = nickname;
            this.Points = current;
        }

        public string Nickname
        {
            get { return this.nickname; }
            set { this.nickname = value; }
        }

        public int Points
        {
            get { return this.points; }
            set { this.points = value; }
        }
    }
}
