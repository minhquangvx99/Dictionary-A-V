using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Dictionary.Business;

namespace Dictionary.DataAccess
{
    class MyData
    {
        //Properties
        public MyDictionary myDictionary = new MyDictionary();
        //Hàm lấy dữ liệu từ tệp txt
        public void LoadData(string path)
        {
            StreamReader sr = new StreamReader(path);
            string dic = sr.ReadLine();
            if (dic != null)
            {
                //chuyển đổi chuỗi ký tự đã cho thành chuỗi chữ thường
                dic = dic.ToLower();
                dic = dic.Trim();
                int check = 1;
                while (check == 1)
                {
                    string key = "";
                    string value = "";
                    int i = 0;
                    if (dic == "" || dic == null || dic[i] != '@')
                    {
                        check = 0;
                    }
                    else
                    {
                        i++;
                        int len = dic.Length;
                        while (i < len && dic[i] != '/')
                        {
                            key = key + dic[i];
                            i++;
                        }
                        //trả về bản sao của chuỗi, bỏ qua phần khoảng trắng ở đầu và sau.
                        key = key.Trim();
                        int temp = 0;
                        while (i < len)
                        {
                            value = value + dic[i];
                            i++;
                            temp = 1;
                        };
                        dic = sr.ReadLine();
                        while (dic != "" && dic != null && dic[0] != '@' && dic != "\t")
                        {
                            //chuyển đổi chuỗi ký tự đã cho thành chuỗi chữ thường
                            dic = dic.ToLower();
                            //trả về bản sao của chuỗi, bỏ qua phần khoảng trắng ở đầu và sau.
                            dic = dic.Trim();
                            if (temp == 1)
                            {
                                value = value + Environment.NewLine + dic;
                            }
                            else
                            {
                                value = value + dic;
                                temp = 1;
                            }

                            dic = sr.ReadLine();
                        }
                        myDictionary.myHashTable.AddKey(key, value);
                        if (dic == null || dic == "" || dic == "\t")
                        {
                            dic = sr.ReadLine();
                        }
                    }
                }
            }
            sr.Close();
        }
    }
}
