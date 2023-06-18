using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderGameChapterNamespace
{
    public class Character
    {
        public string ChapterClass { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Класс персонажа: {ChapterClass}");
            Console.WriteLine($"Здоровье: {Health}");
            Console.WriteLine($"Атака: {AttackPower}");
            Console.WriteLine();
        }
    }
}
