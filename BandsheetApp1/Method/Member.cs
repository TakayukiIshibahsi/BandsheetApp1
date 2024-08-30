using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
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

        public Boolean IsMember(string memberName) 
        {
            Boolean isMember = false;

            string hiragana = @"[あ-ん]+";
            Regex regex = new Regex(hiragana);
            //ここに正規表現の判定結果からメンバーかどうか判断する(おそらくひらがな)
            
            Match match = regex.Match(memberName);

            if (match.Success) 
            {
                isMember = true;
            }

            return isMember;
        }
    }
}
