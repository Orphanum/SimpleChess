using System;

namespace SimpleChess
{
    abstract class Piece
    {
        public string Symbol { get; }

        public Piece(string symbol)
        {
            Symbol = symbol;


        }
        public abstract bool Move(string fromPosition, string toPosition);
    }
}
