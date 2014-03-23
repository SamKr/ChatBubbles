using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBubbles
{
    public enum MessageSide
    {
        Me,
        You
    }

    public class Message
    {
        private static DateTime _now = DateTime.Now;
        private static Random _rand = new Random();

        public Message()
        {
            Timestamp = _now;
            _now = _now.AddMinutes(_rand.Next(100));
        }

        public string Text { get; set; }

        public DateTime Timestamp { get; set; }

        public MessageSide Side { get; set; }
        public MessageSide PrevSide { get; set; }
    }
}
