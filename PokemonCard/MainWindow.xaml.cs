using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PokemonCard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PokemonCardModel pokemonCardModel = new PokemonCardModel
            {
                Name = "Pikachu",
                Hp = "80⚡",
                SubInfo = "Pikachu is a cool guy very heaevy very short",
                ElementType = ElementType.Electric,
                Attacks =
                {
                    new PokemonAttack
                    {
                        Name = "Lightning bolt",
                        Damage = "79",
                        Description = "Pbzzz pszzzt shock",
                        ElementType = ElementType.Electric
                    },

                    new PokemonAttack
                    {
                        Name = "Quick Attack",
                        Damage = "20",
                        Description = "Quick as fuck",
                        ElementType = ElementType.Electric
                    }
                },
                Weakness = "Rock",
                Resistance = "Water",
                Retreat = "Go home",
                SetNumber = "19/151",
                FooterText = "Always brimming with power, it passses timie by lifting potatoes",
                Rarity = "DOT"
            };

            SetUpWindow(pokemonCardModel);
        }

        public void SetUpWindow(PokemonCardModel pokemon)
        {
            NameTextBlock.Text = pokemon.Name;
            HpTextBlock.Text = pokemon.Hp;
            SubInfoTextBlock.Text = pokemon.SubInfo;

            Attack1IconTextBlock.Text = pokemon.Attacks[0].ElementType.ToString();
            Attack1NameTextBlock.Text = pokemon.Attacks[0].Name;
            Attack1DMGTextBlock.Text = pokemon.Attacks[0].Damage;
            Attack1DescTextBlock.Text = pokemon.Attacks[0].Description;

            Attack2Icon.Text = pokemon.Attacks[1].ElementType.ToString();
            Attack2NameTextBlock.Text = pokemon.Attacks[1].Name;
            Attack2DMGTextBlock.Text = pokemon.Attacks[1].Damage;
            Attack2DescTextBlock.Text = pokemon.Attacks[1].Description;

            WeaknessTextBlock.Text = pokemon.Weakness;
            ResistanceTextBlock.Text = pokemon.Resistance;
            RetreatTextBlock.Text = pokemon.Retreat;

            SetNumberTextBlock.Text = pokemon.SetNumber;
            FooterTextTextBlock.Text = pokemon.FooterText;
            CopyWrightTextBlock.Text = pokemon.Rarity;
            
            
        }
    }
}