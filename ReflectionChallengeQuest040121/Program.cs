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
}
