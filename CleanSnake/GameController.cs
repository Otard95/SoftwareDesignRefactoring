using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CleanSnake {
    class GameController {

        private Snake snake;
        private Apple apple;
        private InputHandler IH;
        private Thread IHThread;
        private Display display;
        private bool playing, paused;
        private short ticksPerSecond;

        public GameController () {

            // Setup primitives
            playing = true;
            paused = false;
            ticksPerSecond = 10;

            // Setup the snake and apple
            snake = new Snake(new Vector2D(1, 0));
            apple = new Apple(snake.BodyToVector2D());

            // Initilize the input handler
            IH = new InputHandler();
            IHThread = new Thread(IH.Run);
            IHThread.Start();
            // make sure thread is alive and running
            while (!IHThread.IsAlive) ;
            Thread.Sleep(1);

            // now last but not least lets set up the display
            display = new Display();
            display.PaintSnake(snake.parts);
            display.PaintApple(apple);

        }

        public void Run () {
            


        }

        private void Cleanup() {

            // shutdown IH 
            Console.WriteLine("Shuting down...");
            IH.Shutdown();
            IHThread.Join();
            Console.Write("All done! Goodbye o/");

        }

    }
}
