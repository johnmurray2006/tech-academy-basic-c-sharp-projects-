﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
   public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }  
        public int Balance { get; set; }
        public bool isActivelyPlaying { get; set; }
        public static Game operator+ (Game game, Player player) // the first step to adding an operator overload
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
