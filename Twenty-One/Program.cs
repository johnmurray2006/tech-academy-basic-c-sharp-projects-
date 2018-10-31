using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";
            game = game + player; //the better way game+=player game-=player
            game = game - player;

            Deck deck = new Deck();
            deck.Shuffle(2);
            foreach (Card card in deck.Cards )
            {
                Console.WriteLine(card.Face + " of " + card.Suit);

            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

        }
        
        
        //public static Deck Shuffle(Deck deck, int times)
        //{
          //  for (in = 0; i < times; i++)
            //{
              //  deck = Shuffle(deck);
            //}
        }    //return Deck
    }
     

