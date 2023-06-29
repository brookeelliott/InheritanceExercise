using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
		}

        public int approxSize { get; set; }
        public bool hasEyes { get; set; }
        public string scaleColor { get; set; }
        public bool hasClaws { get; set; }
    }
}

