﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SnakeAndLadder snakeandladder = new SnakeAndLadder();
            //snakeandladder.SinglePlayer();

            //DiceRoll getnumber = new DiceRoll();
            //getnumber.RollTheDice();

            //CheckOption No_player = new CheckOption();
            //No_player.Checkforoption();

            //WinningPosition positionmoves = new WinningPosition();
            //positionmoves.PlayerPosition();

            //ExactWinning OBJ = new ExactWinning();
            //OBJ.Position100();

            //WinTheGame everyroll = new WinTheGame();
            //everyroll.PositionAfterEveryRoll();

            For2Players for2players = new For2Players();
            for2players.Twoplayers();
        }
    }
}
