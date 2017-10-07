using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CleanSnake {
    class InputHandler {

        private ConsoleKeyInfo _lastKeyPress;
        private volatile bool _running;

        public InputHandler () {
            _running = true;
        }

        public void Run () {
            while (_running) {

                if (Console.KeyAvailable) _lastKeyPress = Console.ReadKey();

            }
        }

        public void Shutdown () {
            _running = false;
        }

        public Input GetInput() {
            switch (_lastKeyPress.Key) {
                case ConsoleKey.Escape:
                    return new Input(InputType.OPPERATION, _lastKeyPress.Key);
                case ConsoleKey.Spacebar:
                    return new Input(InputType.OPPERATION, _lastKeyPress.Key);
                case 

            }
        }

    }
}
