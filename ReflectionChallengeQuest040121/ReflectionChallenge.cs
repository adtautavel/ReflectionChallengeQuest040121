using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ReflectionChallengeQuest040121
{
    class ReflectionChallenge
    {
        //Ecrire une classe qui permet d'inspecter des classes
        private Type _objectType;

        public ReflectionChallenge(Type objectType)
        {
            _objectType = objectType;
        }

        public void GetAllProperties()
        {
            PropertyInfo[] properties = _objectType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

            Console.WriteLine("Properties : ");
            foreach (var p in properties)
            {
                Console.WriteLine("\t" + p + "\n\t Name : " + p.Name + "\n\t Attributes : " + p.Attributes + "\n");
            }
        }

        public void GetAllFields()
        {
            FieldInfo[] fields = _objectType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            Console.WriteLine("Fields : ");
            foreach (var f in fields)
            {
                Console.WriteLine("\t" + f + "\n\t Name : " + f.Name + "\n\t Family : " + f.IsFamily + "\n\t Public : " + f.IsPublic + "\n");
            }

        }

        public void GetAllMethods()
        {
            MethodInfo[] methods = _objectType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            Console.WriteLine("Methods : ");
            foreach (var m in methods)
            {
                Console.WriteLine("\t" + m + "\n\t Name : " + m.Name + "\n\t Attributes : " + m.Attributes + "\n\t Public : " + m.IsPublic + "\n");
            }

        }
    }
}
