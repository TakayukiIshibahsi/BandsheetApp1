using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandsheetApp1.Object
{
    public struct Band      //バンドの構造体、メンバーとバンド名を持つ。
    {
        public string BandName;           // バンド名前
        public string[] MemberNameArray;    // バンドメンバーの配列

        // コンストラクタ
        public Band(string bandName, string[] memberNameArray)
        {
            BandName = bandName;
            MemberNameArray = memberNameArray;
        }

        // メソッドで表示
        public void DisplayNames()
        {
            Console.WriteLine("Band Name: " + BandName);
            Console.WriteLine("Member: ");
            foreach (var n in MemberNameArray)
            {
                Console.WriteLine(n);
            }
        }

        //既存のメンバーと重複があるかどうかの確認
        public Boolean DualCheck(string[] existingmember)
        {
            foreach (var n in MemberNameArray)
            {
                foreach (var member in existingmember)
                {
                    if (member.Equals(n))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
