using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionChallengeQuest040121
{
    class ReflectedClass
    {
        private int _id;
        private string Name { get; set; }

        public ReflectedClass()
        {
            _id = 0;
            Name = String.Empty;
        }

        private void DoSomething()
        {
            Console.WriteLine("I am doing something...");
        }
    }
}
