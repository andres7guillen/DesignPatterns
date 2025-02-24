using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutabilityWithCopy.Entities._02_Task
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Level { get; set; }

        public Player(string name, int score, int level)
        {
            Name = name;
            Score = score;
            Level = level;
        }

        public Player CopyWith(string withName = null, int? withScore = null, int? withLevel = null) 
        {
            return new Player(
                name: withName ?? Name,
                score: withScore ?? Score,
                level: withLevel ?? Level
                );
        }

        public void DisplayInfo() 
        {
            Console.WriteLine($"\nEl player de nombre: {Name}, hizo un puntaje de: {Score} y es del nivel: {Level}");
        }

    }
}
