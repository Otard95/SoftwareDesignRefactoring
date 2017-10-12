using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSnake {
	class Apple : Vector2D {

		public char Icon { get; set; }
		private Random rnd;

		public Apple (int xMax, int yMax, List<Vector2D> mask, int x = 0, int y = 0) : base(x, y) { // initilize the apples pos somewhere not on the snake
			ChangePos(xMax, yMax, mask);
			Icon = '$';
			rnd = new Random();
		}

		public void ChangePos (int xMax, int yMax, List<Vector2D> mask = null) { // !!#!#!# MUST FIX !!#!#!#!#!#!#
			bool okPos = false;
			while (!okPos) {
				X = rnd.Next(0, xMax);
				Y = rnd.Next(0, yMax);
				if (checkIsOutside(mask)) {
					okPos = true;
				}
			}
		}

		private bool checkIsOutside (List<Vector2D> mask) {
			bool isOutside = true;
			foreach (Vector2D v in mask) {
				if (this == v) {
					isOutside = false;
				  break;
				}
			}
			return isOutside;
		}

	}
}
