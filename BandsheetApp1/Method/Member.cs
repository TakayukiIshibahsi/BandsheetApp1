using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BandsheetApp1.Object;

namespace BandsheetApp1.Method
{
    public class Member
    {
        public string[] AddExistingMember(string[] existingMember, Band band)
        {
            foreach (var item in band.MemberNameArray)
            {
                existingMember.Append(item);
            }
            return existingMember;
        }
    }
}
