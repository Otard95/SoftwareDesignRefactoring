using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CleanSnake {
    class InputHandler {

        private volatile ConsoleKey _lastKeyPress;
        private volatile bool _running;

        public InputHandler () {
            _running = true;
        }

        public void Run () {
            while (_running) {

                if (Console.KeyAvailable) _lastKeyPress = Console.ReadKey().Key;

            }
        }

        public void Shutdown () {
            _running = false;
        }

        public Input GetInput() {
            switch (_lastKeyPress) {
                case ConsoleKey.Escape:
                    return new Input(InputType.OPPERATION, _lastKeyPress);

                case ConsoleKey.Spacebar:
                    return new Input(InputType.OPPERATION, _lastKeyPress);

                case ConsoleKey.UpArrow:
                    return new Input(InputType.MOVE, _lastKeyPress, new Vector2D(0, -1));

                case ConsoleKey.DownArrow:
                    return new Input(InputType.MOVE, _lastKeyPress, new Vector2D(0,  1));

                case ConsoleKey.RightArrow:
                    return new Input(InputType.MOVE, _lastKeyPress, new Vector2D(1,  0));

                case ConsoleKey.LeftArrow:
                    return new Input(InputType.MOVE, _lastKeyPress, new Vector2D(-1, 0));

                default:
                    return null;

            } // END switch
        } // END GetInput()

    }
}
