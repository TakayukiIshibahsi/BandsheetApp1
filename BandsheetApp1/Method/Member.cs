using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using BandsheetApp1.Object;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BandsheetApp1.Method
{
    public class Member
    {
        public List<string> AddExistingMember(List<string> existingMember, Band band)
        {
            foreach (var item in band.MemberNameArray)
            {
                if (!existingMember.Contains(item))
                {
                    existingMember.Add(item); // Add メソッドを使用してリストにアイテムを追加
                }
            }
            return existingMember;
        }

        public Boolean IsMember(string memberName) 
        {
            Boolean isMember = false;

            string hiragana = "^[あ-んー]+$";
            Regex regex = new Regex(hiragana);
            //ここに正規表現の判定結果からメンバーかどうか判断する(おそらくひらがな)
            
            Match match = regex.Match(memberName);

            if (match.Success) 
            {
                isMember = true;
            }

            return isMember;
        }

        public List<Band> UpdateBandListWeight(Band[] bands) 
        {
            Dictionary<string,int> memberWeight = new Dictionary<string,int>();
            foreach (Band band in bands) 
            {
                List<string> members = band.MemberNameArray;
                foreach(string mem in members)
                {
                    if (!memberWeight.ContainsKey(mem)) 
                    {
                        memberWeight[mem] = 1;
                    }
                    else
                    {
                        memberWeight[mem]++;
                    }
                }
            }

            int index = 0;
            foreach (Band band in bands)
            {
                bands[index].Weight = band.MemberNameArray.Sum(member => memberWeight[member]);
                index++;
            }

            Array.Sort(bands);
            Array.Reverse(bands);   //降順にソート

            List<Band> bandList = bands.ToList();

            return bandList;
        }

        public int BandCount(IEnumerable<Band> bands)
        {
            int count = 0;
            foreach (Band band in bands)
            {
                count++;
            }
            return count;
        }

        public Band[][] AutomaticBandsheet(int columns, int rows, List<Band> bands)
        {
            // Band[][] 配列の初期化
            Band[][] bandSheet = new Band[rows][];
            for (int i = 0; i < rows; i++)
            {
                bandSheet[i] = new Band[columns];
            }

            // バンド数の取得と練習回数の計算
            int bandNum = BandCount(bands);  // バンド数
            int practice = (rows * columns) / bandNum;  // 練習回数

            List<List<Band>> allBandList = new List<List<Band>>();//練習回数に応じたリストのリストを用意これをだんだん減らしていく
            for (int i=0; i< practice; i++)
            {
                allBandList.Add(new List<Band>(bands));
            }

            // 各行を処理
            for (int i = 0; i < rows; i++)
            {
                if (BandCount(allBandList[practice-1]) ==0)
                {
                    // 練習回数がゼロの場合、デフォルトのバンドで埋める
                    for (int j = 0; j < columns; j++)
                    {
                        bandSheet[i][j] = new Band("", new List<string>(), 0);
                    }
                    continue; // 次の行へ
                }

                List<int> index= new List<int>();
                for (int k = 0; k < practice; k++)
                {
                    index.Add(0);
                }
                List<string> existingMembers = new List<string>();
                int nowList = 0; //どのリストを指定しているか

                for (int j = 0; j < columns; j++)
                {
                   
                    while (true)
                    {
                        List<Band> bandList = allBandList[nowList];
                        if (index[nowList] < BandCount(bandList))
                        {
                            Band band = bandList[index[nowList]];
                            if (!band.DualCheck(existingMembers))
                            {
                                bandSheet[i][j] = band;
                                existingMembers = AddExistingMember(existingMembers, band);
                                bandList.RemoveAt(index[nowList]); // 使用したバンドを削除
                                break; // 次のセルへ
                            }
                            else
                            {
                                index[nowList]++;
                            }
                        }
                        else
                        {
                            if (nowList < practice - 1)
                            {
                                nowList++;
                            }
                            else
                            {
                                // 残りのセルをデフォルトのバンドで埋める
                                for (; j < columns; j++)
                                {
                                    bandSheet[i][j] = new Band("", new List<string>(), 0);
                                }
                                break; //次の行へ
                            }

                        }
                    }
                }
                existingMembers.Clear();
            }
            if(BandCount(allBandList[practice - 1]) != 0)
            {
                string pastBand = "";
                foreach(List<Band> list in allBandList)
                {
                    foreach(Band band in list)
                    {
                        pastBand = band.BandName + ", ";
                    }
                }
                MessageBox.Show("入ることができなかったバンドがあります\n"+pastBand);
            }
            else
            {
                MessageBox.Show("すべてのバンドが枠に収まっています\n");
            }
            return bandSheet;
        }

    }
}
