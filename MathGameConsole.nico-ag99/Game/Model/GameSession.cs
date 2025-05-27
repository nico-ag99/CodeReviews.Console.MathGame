using System.Diagnostics;

namespace Game.Model
{
    internal class GameSession
    {
        public int Score { get; set; }
        public string? Name { get; set; }
        public List<string> History { get; set; } = new List<string>();
        public Stopwatch stopwatch = new Stopwatch();

        public void ResetScore() => Score = 0;
        public void SaveGameData(string mode, string difficulty) 
        {
            History.Add($"| {Name, -8} |   {Score.ToString()}   | {difficulty,-10} | {DateTime.Now.ToString("dd/MM/yyyy")} | {GetElapsedTime()} | {mode, - 14} |");
        }

        public string GetElapsedTime()
        {
            TimeSpan elapsedTime = stopwatch.Elapsed;
            return $"{elapsedTime.Minutes:D2}:{elapsedTime.Seconds:D2}";
        }
    }
}
