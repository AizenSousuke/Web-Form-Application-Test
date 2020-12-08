using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplicationTest
{
    public class InterfaceTest
    {
        public interface Person
        {
            string Name { get; set; }
            int Age { get; set; }
        }

        public interface Male
        {
            string ExtraThingy { get; }
            void FindWork();
        }

        public interface Female
        {
            bool LoudMouth { get; }
        }

        public class Nik : Male, Person
        {
            public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public string ExtraThingy => throw new NotImplementedException();

            public void FindWork()
            {
                Debug.WriteLine("Finding work.");
            }
        }

        public class AnotherPerson
        {
            public string Job { get; set; }
        }

        AnotherPerson person = new AnotherPerson();
        void Method()
        {
            
        }
    }
}