using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSnake {
	class Snake {

		public List<BodyPart> parts;
		public Vector2D LastDir; // movement direction of snake

		public Snake (Vector2D startDir) { // Initial movement dir of snake
			// Create snake
      parts = new List<BodyPart>();
		}

		public BodyPart GetNewHead () {

			// returns a new BodyPart with icon head using the current dir to move it correctly
			// make sure to change the icon of the last head to the body icon
		  parts[parts.Count - 2].Icon = BodyPartIcon.BODY;
      return new BodyPart(BodyPartIcon.HEAD);
		}

		public void UpdateHead (BodyPart newHead) { // add the new head to the parts List
      parts.Add(GetNewHead());
		}

		public List<Vector2D> BodyToVector2D () { // makes new list ov Vector2D and populates it by converting each BodyPart to a vector
		  var vectorList = new List<Vector2D>();
		  foreach (var variable in parts)
		  {
		    vectorList.Add(variable);
		  }
		  return vectorList;
		}

    public void RemoveTail()
	  {
	    parts.Remove(parts[0]);
	  }


	}
}
