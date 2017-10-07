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

			while (playing) {

				// Get and handle input
				Input _in = IH.Input;
				HandleInput(_in);

				// if we are paused stop here and redo while
				if (paused) continue;

				// Now that we got our input wich at this point should have been handled
				// lets calculate the next frame and print it

				

			} // END While

			// Do ceanup before exit
			Cleanup();

		}

		private void HandleInput(Input _in) {
			if (_in != null) {
				if (_in.Type == InputType.OPPERATION) {

					if (_in.Key == ConsoleKey.Spacebar) { // pause the game
						paused = !paused;
					} else if (_in.Key == ConsoleKey.Escape) {
						playing = false;
					}


				} else { // currently only two InputTypes so this has to be InputType.MOVE

					if (_in.Dir != snake.LastDir && // if same dir no need to update
							_in.Dir != Vector2D.Multiply(snake.LastDir, -1) /* if exact oposite can't upate*/) {

						snake.LastDir = _in.Dir;

					}

				} // END Direction handling
			} // END If _in != null
		} // END HandleInput()

		private void Cleanup () {

			// shutdown IH 
			Console.WriteLine("Shuting down...");
			IH.Shutdown();
			IHThread.Join();
			Console.Write("All done! Goodbye o/");

		}

	}
}
