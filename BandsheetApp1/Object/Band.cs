using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandsheetApp1.Object
{
    public struct Band      //バンドの構造体、メンバーとバンド名を持つ。
    {
        public string BandName { get; set; }          // バンド名前
        public List<string> MemberNameArray { get; set; }    // バンドメンバーの配列

        public string MemberNames => string.Join(", ", MemberNameArray);

        // コンストラクタ
        public Band(string bandName, List<string> memberNameArray)
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
        public Boolean DualCheck(List<string> existingmember)
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
