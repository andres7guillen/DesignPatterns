using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Entities._02_Task;

public class Pokemon
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Level { get; set; }
    public List<string> Attacks { get; set; } = new List<string>();

    public Pokemon(string name, string type, int level, List<string> attacks)
    {
        Name = name;
        Type = type;
        Level = level;
        Attacks = attacks;
    }

    public string DisplayInfo() 
    {
        return $"Pokemon: {Name} es de tipo: {Type}, con un nivel: {Level}, y los " +
            $"ataques son: {string.Join(",", Attacks)}";
    }

    public Pokemon Clone() 
    { 
        return new Pokemon(this.Name, this.Type, this.Level, this.Attacks);
    }

}
