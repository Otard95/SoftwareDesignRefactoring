using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSnake {
    class Input {

        public InputType Type;
        public Vector2D Dir;

        public Input (InputType t, Vector2D v = null) {
            Type = t;
            Dir = v;
        }

    }
}
