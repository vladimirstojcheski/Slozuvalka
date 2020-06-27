using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сложувалка
{
    public class GameOne
    {
        public Char[] letters { get; set; }
        public HashSet<String> dictonary { get; set; }

        public GameOne(Char[] letters)
        {
            this.letters = letters;
            this.dictonary = new HashSet<string>();
            dictonary.Add("МИНИСТЕРСТВО");
            dictonary.Add("НЕТО");
            dictonary.Add("МИНИСТЕР");
            dictonary.Add("СНИМИ");
            dictonary.Add("МИНИ");
            dictonary.Add("ТЕРМИ");
            dictonary.Add("ТЕРМИН");
            dictonary.Add("СТО");
            dictonary.Add("ТРИ");
            dictonary.Add("ТРИМ");
            dictonary.Add("СИМНЕ");
            dictonary.Add("ТЕСТ");
            dictonary.Add("СТРЕС");
            dictonary.Add("СТРЕСОВИ");
            dictonary.Add("СТОМНИ");
            dictonary.Add("СНИМИ");
            dictonary.Add("ТЕТРИС");
            dictonary.Add("ТЕТРИСИ");
            dictonary.Add("РОСИ");
            dictonary.Add("МИРИС");
            dictonary.Add("СИН");
            dictonary.Add("СИНОВИ");
            dictonary.Add("РИС");
            dictonary.Add("РИСОВИ");
            dictonary.Add("РИСЕВИ");
            dictonary.Add("ЕМИТЕР");
            dictonary.Add("ЕМИТЕРИ");
            dictonary.Add("ТРЕТ");
            dictonary.Add("ТРЕТИ");
            dictonary.Add("НИВО");
            dictonary.Add("СТОРЕНИ");
            dictonary.Add("СТОРЕН");
            dictonary.Add("ОВИЕ");
            dictonary.Add("ОНИЕ");
            dictonary.Add("ТИЕ");
            dictonary.Add("ВИЕ");
            dictonary.Add("НИЕ");
            dictonary.Add("ТИ");
            dictonary.Add("НИВ");
            dictonary.Add("НИМ");
            dictonary.Add("МИР");
            dictonary.Add("СЕРВИС");
            dictonary.Add("СЕРВИСИ");
            dictonary.Add("ОВИЕ");
            dictonary.Add("ОНИЕ");
            dictonary.Add("НЕВИН");
            dictonary.Add("НЕВИНИ");
            dictonary.Add("НЕВИНО");
            dictonary.Add("ВЕРНИ");
            dictonary.Add("ВЕРНО");
            dictonary.Add("СЕТ");
            dictonary.Add("СЕТОВИ");
            dictonary.Add("СОС");
            dictonary.Add("СИСТЕМ");
            dictonary.Add("СИСТЕМИ");
            dictonary.Add("ТЕМНО");
        }
    }
}
