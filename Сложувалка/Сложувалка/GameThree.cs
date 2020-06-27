using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сложувалка
{
    public class GameThree
    {
        public String topic { set; get; }
        public Dictionary<String, String> pairs { set; get; }

        public GameThree(String topic, Dictionary<String, String> pairs)
        {
            this.topic = topic;
            this.pairs = pairs;
        }
    }
}
