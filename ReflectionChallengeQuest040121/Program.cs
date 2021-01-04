using System;
using System.Reflection;
using ReflectionChallengeQuest040121;

namespace ReflectionChallengeQuest040121
{
    class Program
    {
        static void Main(string[] args)
        {
            var reflected = new ReflectedClass();
            Type objectType = reflected.GetType();
            ReflectionChallenge reflector = new ReflectionChallenge(objectType);
            reflector.GetAllProperties();
            reflector.GetAllMethods();
            reflector.GetAllFields();
        }
    }
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
