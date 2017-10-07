using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CleanSnake {
    class InputHandler {

        /*
         * ## private fields
         */

        private volatile ConsoleKey _lastKeyPress;
        private volatile bool _running;

        /*
         * ## Proporty
         */
        public Input Input {
            get {
                switch (_lastKeyPress) {
                    case ConsoleKey.Escape:
                        return new Input(InputType.OPPERATION, _lastKeyPress);

                    case ConsoleKey.Spacebar:
                        return new Input(InputType.OPPERATION, _lastKeyPress);

                    case ConsoleKey.UpArrow:
                        return new Input(InputType.MOVE, _lastKeyPress, new Vector2D(0, -1));

                    case ConsoleKey.DownArrow:
                        return new Input(InputType.MOVE, _lastKeyPress, new Vector2D(0, 1));

                    case ConsoleKey.RightArrow:
                        return new Input(InputType.MOVE, _lastKeyPress, new Vector2D(1, 0));

                    case ConsoleKey.LeftArrow:
                        return new Input(InputType.MOVE, _lastKeyPress, new Vector2D(-1, 0));

                    default:
                        return null;

                } // END switch
            } // END get;
        }

        /*
         * ## Constructor
         */

        public InputHandler () {
            _running = true;
        }

        /*
         * ## Run methud for the Thread
         */

        public void Run () {
            while (_running) {

                if (Console.KeyAvailable) _lastKeyPress = Console.ReadKey().Key;

            }
        }

        /*
         * ## Shutdown methud for graceful exit
         */

        public void Shutdown () => _running = false;

    }
}
