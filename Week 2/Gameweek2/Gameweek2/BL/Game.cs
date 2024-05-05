using System;

namespace Gameweek2
{

    internal class Enemy
    {
        public int X;
        public int Y;
        public char Symbol;
        public Enemy(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        public void Move(string direction)
        {
            if (direction == "Up")
            {
                Y--;
            }
            else if (direction == "Down")
            {
                Y++;
            }
        }

        public void Print()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }

        public void Erase()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
        }
    }

    internal class Player
    {
        public int X;
        public int Y;
        public char Symbol;

        public Player(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        public void Move(int newX, int newY)
        {
            X = newX;
            Y = newY;
        }

        public void Print()
        {
            Console.SetCursorPosition(Y, X);
            Console.Write(Symbol);
        }

        public void Erase()
        {
            Console.SetCursorPosition(Y, X);
            Console.Write(" ");
        }
    }
}