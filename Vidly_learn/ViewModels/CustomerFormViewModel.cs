using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_learn.Models;

namespace Vidly_learn.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; } //dont use list because we dont need to do add, edit operations to the membershiptype in here. We only need to iterate all membershiptypes. So IEnumerable is better to use
        public Customer Customer{ get; set; }

    }
}