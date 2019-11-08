using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrincess
{
   
    class Game
    {
        GameField gf;
        Player player;
        public Game (GameField Agf, Player Aplayer)
        {
            gf = Agf;
            player = Aplayer;
        }
        public void Start(bool showTraps)
        {
            bool gameOver = false;
            Console.Clear();
            gf.Print(showTraps);
            PutStringToConsole("Try to Finish!", 0, GameField.size + 3);
            PutStringToConsole("Use arrows keys", 0, GameField.size + 4);
            Console.SetCursorPosition(0,0);
            
            while (!gameOver)
            {
                Position playerPrevPos = (Position)player.pos.Clone();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                bool isMoved = MovePlayer(keyInfo);
                if (isMoved)
                {
                    PutCharToConsole('.', playerPrevPos.X * 3, playerPrevPos.Y);
                    if (player.pos == gf.finalPos)
                    {
                        PutCharToConsole('W', player.pos.X * 3, player.pos.Y);
                        ClearLineFrom(0, GameField.size + 5);
                        PutStringToConsole("You are winner!", 0, GameField.size + 5);
                        gameOver = true;
                        break;
                    }
                    else if (gf.field[player.pos.X, player.pos.Y] != 0)
                    {
                        player.hp -= gf.field[player.pos.X, player.pos.Y];
                        if (player.hp < 1)
                        {
                            PutCharToConsole('X', player.pos.X * 3, player.pos.Y);
                            ClearLineFrom(0, GameField.size + 5);
                            PutStringToConsole("You are dead!", 0, GameField.size + 5);
                            gameOver = true;
                            break;
                        }
                        gf.field[player.pos.X, player.pos.Y] = 0;
                        PutCharToConsole('P', player.pos.X * 3, player.pos.Y);
                    }
                    else
                    {
                        PutCharToConsole('P', player.pos.X * 3, player.pos.Y);
                    }
                    ClearLineFrom(0, GameField.size + 5);
                    PutStringToConsole("Player HP:" + player.hp.ToString(), 0, GameField.size + 5);
                }
            }
            System.Threading.Thread.Sleep(1000);
        }

        bool MovePlayer(ConsoleKeyInfo keyInfo)
        {
            bool moved = false;
            switch (keyInfo.Key)
            {
                
                case ConsoleKey.LeftArrow:
                    {
                        if (player.pos.X > 0)
                        {
                            moved = true;
                            player.MoveLeft();
                        }
                        break;
                    }
                case ConsoleKey.UpArrow:
                    {
                        if (player.pos.Y > 0)
                        {
                            moved = true;
                            player.MoveUp();
                        }
                        break;
                    }
                case ConsoleKey.RightArrow:
                    {
                        if (player.pos.X < GameField.size - 1)
                        {
                            moved = true;
                            player.MoveRight();
                        }
                        break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        if (player.pos.Y < GameField.size - 1)
                        {
                            moved = true;
                            player.MoveDown();
                        }
                        break;
                    }
                case ConsoleKey.Q:
                    {
                        return moved;
                    }
                default:
                    {
                        break;
                    }

            }
            return moved;
        }
        void PutCharToConsole(char ch,int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ch);
        }
        void PutStringToConsole(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(message);
        }
        static void ClearLineFrom(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("                                        ");
        }
    }
}
