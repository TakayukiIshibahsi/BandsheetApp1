using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandsheetApp1.Object
{
    public class Band : IComparable<Band>
    {
        public string BandName { get; set; }          // バンド名前
        public List<string> MemberNameArray { get; set; }    // バンドメンバーのリスト
        public int Weight { get; set; }                // weight プロパティとして定義

        // メンバー名をカンマ区切りの文字列として取得
        public string MemberNames => string.Join(", ", MemberNameArray);

        // コンストラクタ
        public Band(string bandName, List<string> memberNameArray, int weight = 0)
        {
            BandName = bandName;
            MemberNameArray = memberNameArray;
            Weight = weight;
        }

        // IComparable<Band> インターフェースの実装
        public int CompareTo(Band? other)
        {
            if (other == null) return 1;
            // weightで比較（昇順）
            return this.Weight.CompareTo(other.Weight);
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
        public Boolean DualCheck(List<string> existingMembers)
        {
            

            foreach (string n in MemberNameArray)
            {
                foreach (string member in existingMembers)
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
