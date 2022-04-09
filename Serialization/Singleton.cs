using System;

namespace laba1_OOP.Plugins
{
    public static class Singleton
    {
        public static Serializer Serializer { get; }

        public static int A { set => _a = value; }
        private static int _a;
        static Singleton() //статический конструктор вызывается во время первого обращения
        {
            Serializer  = new Serializer();
        }
        
    }
}