using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Game
    {
        int boardWidth;
        int boardHeight;
        Board board;
        UserInterface ui;

        public Game()
        {
            Console.WriteLine("Starting Game1");
        }

        public void RunGame()
        {
            InitializeGame();
            while (true)
            {
                ProcessInput();
                Update();
                Render();
            }
        }

        void InitializeGame()
        {
            boardHeight = 10;
            boardWidth = 10;
            board = new Board();
            ui = new UserInterface();
        }

        void ProcessInput()
        {

        }

        void Update()
        {

        }

        void Render()
        {

        }


        


    }
}
