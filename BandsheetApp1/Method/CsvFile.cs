using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BandsheetApp1.Object;
using BandsheetApp1.Method;


namespace BandsheetApp1.Method
{
    internal class CsvFile
    {
        public List<Band> ReadCsvFile(string filePath)
        {
            // 結果のバンドリスト
            List<Band> result = new List<Band>();

            if (File.Exists(filePath))
            {
                try
                {
                    // ファイルを1行ずつ読み込む
                    string[] lines = File.ReadAllLines(filePath,Encoding.UTF8);
                    Member mem = new Member();

                    // 各行を処理、つまりバンド単位
                    foreach (string line in lines)
                    {
                        // カンマで分割して各要素を取得
                        string[] columns = line.Split(',');

                        // どのカラムなのか識別できるようにindexを用意
                        int index = 1;
                        bool isBand = false;
                        string bandName = "";
                        List<string> members = new List<string>();

                        // 各要素に対して正規表現を適用、つまりメンバー単位
                        foreach (string column in columns)
                        {
                            if (index == 1)
                            {
                                Regex regex = new Regex(@"\d+"); // スキャンしたものが数かどうか判断
                                Match match = regex.Match(column);

                                if (match.Success)
                                {
                                    isBand = true;
                                }
                            }

                            if (!string.IsNullOrEmpty(column) && index == 3 && isBand)
                            {
                                bandName = column;
                            }

                            if (index > 3 && index<12 && mem.IsMember(column))
                            {
                                members.Add(column);
                            }

                            // インクリメント
                            index++;
                        }

                        if (isBand)
                        {
                            Band band = new Band(bandName, members);
                            result.Add(band);
                        }
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("このファイルは現在使用中です。");
                }
            }
            else
            {
                Console.WriteLine("指定されたファイルが存在しません。");
            }

            return result;
        }
    }
}
