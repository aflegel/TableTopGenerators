﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceCalculator.Dice;

namespace DiceCalculator
{
	class Program
	{
		static void Main(string[] args)
		{

			BreakdownCalculator diceCalculator = new BreakdownCalculator(new List<Die>()
			{
				new Boost(),
				new Boost(),
				new Boost(),
				new Boost(),
				new Boost(),//5
				new Ability(),
				new Ability(),
				new Difficulty(),
				new Difficulty(),
				new Difficulty(),//10
				new Difficulty(),
				new SetBack(),
				new SetBack(),
				new SetBack(),
				new SetBack()
				/*
				//new Boost(),
				new Ability(),
				new Ability(),
				new Ability(),
				new Ability(),
				//new Proficiency(),
				//new Ability(),
				//new Ability(),
				//new Difficulty(),
				//new Difficulty(),
				new Difficulty(),
				new Difficulty(),
				new Difficulty(),
				new Difficulty()*/

			});
		}
	}
}
