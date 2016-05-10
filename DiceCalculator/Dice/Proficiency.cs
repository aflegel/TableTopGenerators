﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceCalculator.Dice
{
	class Proficiency : Die
	{

		public Proficiency()
		{
			faceMaps = new List<FaceMap>();

			faceMaps.Add(new FaceMap(new Dictionary<Face, int>() { { Face.blank, 1 } }));

			faceMaps.Add(new FaceMap(new Dictionary<Face, int>() { { Face.success, 1 } }));

			faceMaps.Add(new FaceMap(new Dictionary<Face, int>() { { Face.success, 1 } }));

			faceMaps.Add(new FaceMap(new Dictionary<Face, int>() { { Face.success, 2 } }));

			faceMaps.Add(new FaceMap(new Dictionary<Face, int>() { { Face.success, 2 } }));

			faceMaps.Add(new FaceMap(new Dictionary<Face, int>() { { Face.advantage, 1 } }));

			faceMaps.Add(new FaceMap(new Dictionary<Face, int>() { { Face.advantage, 1 }, { Face.success, 1 } }));

			faceMaps.Add(new FaceMap(new Dictionary<Face, int>() { { Face.advantage, 1 }, { Face.success, 1 } }));

			faceMaps.Add(new FaceMap(new Dictionary<Face, int>() { { Face.advantage, 1 }, { Face.success, 1 } }));

			faceMaps.Add(new FaceMap(new Dictionary<Face, int>() { { Face.advantage, 2 } }));

			faceMaps.Add(new FaceMap(new Dictionary<Face, int>() { { Face.advantage, 2 } }));

			faceMaps.Add(new FaceMap(new Dictionary<Face, int>() { { Face.triumph, 1 } }));
		}

	}
}
