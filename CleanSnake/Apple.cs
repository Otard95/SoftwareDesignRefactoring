﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSnake {
    class Apple : Vector2D {

        public Apple (List<Vector2D> mask, int x = 0, int y = 0): base(x,y) { // use initilize the apples pos somewhere not on the snake
          bool isOutside = true;
        for (int i = 0; i < mask.Count; i++) {
        if (this == mask[i])
        {
          isOutside = false;
        }
      }
          if (isOutside)
          {
            X = x;
            Y = y;
          }
    }

        public void ChangePos(int xMax, int yMax, List<Vector2D> mask = null){
          Random rnd = new Random();
          bool okPos = false;
          int x;
          int y;
          while (!okPos)
          {
            x = rnd.Next(0, xMax);
            y = rnd.Next(0, yMax);
            for (int i = 0; i < mask.count; i++)
            {
              
            }
          }
    }

    }
}
