using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSnake {
    class GameController {

        private Snake snake;
        private Apple apple;
        private InputHandler IH;
        private Display display;

        public GameController () {
            snake = new Snake();
            apple = new Apple();
        }

    }
}
