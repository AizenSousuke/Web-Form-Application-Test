using Bogus;
using COL.NEA.FAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using AutoBogus;
using System.Diagnostics;

namespace WebApplicationTest.Classes
{
    public class BogusDataAccessor
    {
        public string GenerateFakeData()
        {
            var FakeData = new Faker<DFRequest>();
            FakeData.RuleFor(r => r.RequestNumber, f => f.Random.Replace("NEA/DF/FY2020/00##") + (f.Random.Bool() ? f.Random.Replace("-0#?") : null));

            var FakeRequest = FakeData.Generate(100);

            return JsonConvert.SerializeObject(FakeRequest);
        }

        public string GenerateFakeAutoData()
        {
            AutoFaker.Configure(c =>
            {
                c.WithRecursiveDepth(1);
            });
            var request = AutoFaker.Generate<DFRequest>();
            Debug.WriteLine(JsonConvert.SerializeObject(request));
            return JsonConvert.SerializeObject(request);
        }
    }
}