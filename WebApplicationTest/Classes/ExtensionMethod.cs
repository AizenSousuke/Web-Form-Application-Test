using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplicationTest.Classes
{
    public class ExtensionMethod
    {
        string myString = "Hello nik ashdfadjfashdkfasdf";
        public ExtensionMethod()
        {
        }

        public void Write()
        {
            Debug.WriteLine(myString);
            Debug.WriteLine(myString.TakeFirst5Characters());
            Debug.WriteLine(myString.TakeSomethingElse(10));
        }
    }

    public static class Extension
    {
        public static string TakeFirst5Characters(this string str)
        {
            return str.Substring(0, 5);
        }
    }

    public static class ExtensionAnotherOne
    {
        public static string TakeSomethingElse(this string str, int number)
        {
            return str.Substring(0, number);
        }
    }
}