using System;
using System.Collections.Generic;
using System.Text;

namespace MathGame
{
    internal class Game
    {
        public GameType Type { get; set; }

    }

    internal enum GameType
    {
        Addition,
        Subtraction,
        Division,
        Multiplication,
        Random
    }
}
