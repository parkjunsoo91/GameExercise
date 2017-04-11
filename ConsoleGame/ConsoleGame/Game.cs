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
        event EventHandler Click;
        protected virtual void OnClick(EventArgs e)
        {
            EventHandler handler = Click;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public Game()
        {
            Console.WriteLine("Starting Game1");
        }

        void InitializeGame()
        {
            boardHeight = 10;
            boardWidth = 10;
            board = new Board();
            ui = new UserInterface();
        }

        public void RunGame()
        {
            InitializeGame();
            double previous = TimeSpan.
            while (true)
            {
                ProcessInput();
                Update();
                Render();
            }
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
