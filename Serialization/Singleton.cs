using System;

namespace laba1_OOP.Plugins
{
    public static class Singleton
    {
        public static Serializer Serializer { get; }
        
        static Singleton()
        {
            Serializer  = new Serializer();
        }
        
    }
}