using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCard
{
    public class PokemonCardModel
    {
        public string Name { get; set; }
        public string Hp { get; set; }
        public ElementType ElementType { get; set; }
        public string ImagePath { get; set; }
        public string SubInfo { get; set; }

        public string Weakness { get; set; }
        public string Resistance { get; set; }
        public string Retreat { get; set; }

        public List<PokemonAttack> Attacks { get; set; } = new();

        public string SetNumber { get; set; }
        public string FooterText { get; set; }
        public string Rarity {  get; set; }

    }


    public enum ElementType
    {
        Fire, Water, Grass, Electric, Psychic, Dragon, Fairy, Dark, Fighting, Steel, Colorless, Ice, Rock
    }
}
