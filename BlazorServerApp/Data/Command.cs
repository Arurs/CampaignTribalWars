using System.Drawing;

namespace BlazorServerApp.Data
{
    public class Command
    {
        public int Id { get; set; }
        public DateTime MinTime { get; set; }
        public DateTime MaxTime { get; set; }
        public string Link { get; set; }
        public CommandType CommandType { get; set; }
        public Color RowColor => _GetColor();
        
        private Color _GetColor()
        {
            if (MaxTime < DateTime.Now)
                return Color.Red;
            if (MinTime > DateTime.Now)
                return Color.Gray;
            return Color.LightGreen;
        }
    }
    public enum CommandType
    {
        OFF, FAKE, NOBLe
    }
}
