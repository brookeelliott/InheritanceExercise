using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
		}

        public int wingspan { get; set; }
        public bool flightless { get; set; }
        public string color { get; set; }
        public bool longBeak { get; set; }
    }
}

