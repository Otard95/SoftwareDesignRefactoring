using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSnake {
    class Display {

        public int Height;
        public int Width;

        public Display (int h, int w) {
            Height = h;
            Width = w;
        }

        public void PaintSnake(List<BodyPart> snake) {

        }

        public void UpdateSnake (BodyPart nHead,BodyPart oldHead, BodyPart tail = null) { // old head changes ico repaint it

        }

        public void PaintApple (Apple apple) {

        }

        public bool IsOutside(Vector2D v) {

        }

    }
}
