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
        public Band[] ReadCsvFile(string filePath)
        {
            //結果のバンド列
            Band[] result = null;

            if (File.Exists(filePath))
            {
                try 
                {
                    // ファイルを1行ずつ読み込む
                    string[] lines = File.ReadAllLines(filePath);

                    // 各行を処理
                    foreach (string line in lines)
                    {
                        // カンマで分割して各要素を取得
                        string[] columns = line.Split(',');

                        //どのカラムなのか識別できるようにindexを用意
                        int index = 1;
                        Boolean isBand = false;
                        string bandName = "";
                        string[] member = []; 
                        // 各要素に対して正規表現を適用
                        foreach (string column in columns)
                        {
                            if (index == 1)
                            {
                                Regex regex = new Regex(@"\d+");//スキャンしたものが数かどうか判断
                                Match match = regex.Match(column);

                                if (match.Success)
                                {
                                    isBand = true;
                                    
                                }
                            }

                            if (column != "" && index == 3 && isBand)
                            {
                                MessageBox.Show($"Band name: {column}");
                                bandName = column;
                            }
                            Member mem = new Member();


                            if (index > 3 && index < 12 && mem.IsMember(column))
                                {
                                    member.Append(column);
                                }
                            
                            //インクリメント
                            index++;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("this file is using now!!");
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
