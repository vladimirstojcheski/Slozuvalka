using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сложувалка
{
    public class KojZnaeZnae
    {
        private Dictionary<String, Question> questions;

        public KojZnaeZnae(Dictionary<String, Question> questions)
        {
            this.questions = questions;
        }
    }
}
