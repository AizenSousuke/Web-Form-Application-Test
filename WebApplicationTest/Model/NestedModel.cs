using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplicationTest.Model
{
    public class NestedModel
    {
        public string Name { get; set; }
        public AnotherNestedModel AnotherNestedModel { get; set; }
        public AnotherNestedNestedModel AnotherNestedNestedModel { get; set; }
    }

    public class AnotherNestedModel
    {
        public string AnotherNestedModel_Name { get; set; }
    }
    public class AnotherNestedNestedModel
    {
        public string Name { get; set; }
    }
}