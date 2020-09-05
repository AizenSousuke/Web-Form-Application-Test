using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplicationTest.Classes
{
    public class Enums
    {
        [Flags]
        public enum Abilities {

            Approve = 1,
            Reject = 2,
            Draft = 4,
            Nothing = 8,
            Anything = 16,
            Admin = Approve + Reject + Draft + Anything,
            NormalUsers = Draft + Nothing,
        }

        public enum ActionsOfHOD
        {
            Approve,
            Reject,
        }
        public enum ActionsOfGDCS
        {
            Approve = 100,
            Reject,
            Rework,
        }

        public string ActionICanDo { get; set; }

        public void Main() {
            var normaluser = Abilities.NormalUsers;
            var adminuser = Abilities.Admin;

            // Using flags to set what the users can do
            Debug.WriteLine("Normal user can approve: " + normaluser.HasFlag(Abilities.Approve).ToString());
            Debug.WriteLine("Admin user can approve: " + adminuser.HasFlag(Abilities.Approve).ToString());

            // In workflow do it like this:
            Abilities user;
            Abilities customer;
            user = Abilities.Admin;
            customer = Abilities.NormalUsers;
            if (user.HasFlag(Abilities.Draft))
            {
                Debug.WriteLine("Admin user setting draft");
            }
            // Customer cannot approve, so the code won't run
            if (customer.HasFlag(Abilities.Approve))
            {
                Debug.WriteLine("Customer user setting approve");
            }
            if (customer.HasFlag(Abilities.Draft))
            {
                Debug.WriteLine("Customer user setting draft");
            }


            // ==============


        }
    }
}