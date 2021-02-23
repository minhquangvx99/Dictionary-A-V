using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Dictionary.Business
{
    class MyDictionary
    {
        //Properties
        public MyHashTable myHashTable = new MyHashTable();
        List<string> listkey;
        List<string> listvalue;
        //Hàm thêm một từ vào từ điển
        public bool AddDictionary(string key, string value)
        {
            if (!IsValidString(key))
                return false;
            myHashTable.AddKey(key, value);
            return true;
        }
        //Hàm xóa một từ trong từ điển
        public void RemoveDictionary(string key)
        {
            myHashTable.RemoveKey(key);
        }
        //Hàm thay đổi một từ trong từ điển
        public void ChangeDictionary(string key, string value)
        {
            Node p = myHashTable.SearchKey(key);
            p.value = value;
        }
        //Hàm tìm kiếm một từ trong từ điển
        public Node SearchDictionary(string key)
        {
            return myHashTable.SearchKey(key);
        }
        //Hàm kiểm tra một key có hợp lệ hay không
        private bool IsValidString(string word)
        {
            if (word == null)
                return false;
            word = word.ToLower();
            for (int i = 0; i < word.Length; i++)
                if (word[i] < 'a' && word[i] > 'z')
                    return false;
            return true;
        }
        //Hàm lưu lại dữ liệu
        public void BackUp(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            for(int i=0;i<myHashTable.HT.Count();i++)
            {
                for(Node p=myHashTable.HT[i].pHead;p!=null;p=p.pNext)
                {
                    if(p!=null)
                    {
                        sw.WriteLine("@"+p.key + Environment.NewLine + p.value);
                    }
                    sw.WriteLine("\t");
                }

            }
            sw.Close();
        }
        public int LoadDataToCombobox(ComboBox combo)
        {
            listkey = new List<string>();
            for (int i = 0; i < myHashTable.HT.Count(); i++)
            {
                for (Node p = myHashTable.HT[i].pHead; p != null; p = p.pNext)
                {
                    if (p != null)
                    {
                        listkey.Add(p.key);
                    }
                }
            }
            combo.DataSource = listkey;
            return listkey.Count();
        }
        public void LoadDataToRadioButton(RadioButton rb1, RadioButton rb2, RadioButton rb3, string q)
        {
            listvalue = new List<string>();
            for (int i = 0; i < myHashTable.HT.Count(); i++)
            {
                for (Node p = myHashTable.HT[i].pHead; p != null; p = p.pNext)
                {
                    if (p != null)
                    {
                        listvalue.Add(p.value);
                    }
                }
            }
            int l = listvalue.Count();
            Random r = new Random();
            int[] x = new int[3];
            int y = 0;
            for (int i = 0; i < 3; i++)
            {
                int idx = r.Next(0, l-1);
                while (listvalue[idx] == q)
                {
                    idx = r.Next(0, l - 1);
                }
                if (y > 0)
                {
                    int check = 1;
                    while (check == 1)
                    {
                        for (int z = 0; z < y; z++)
                        {
                            if (idx == x[z] || listvalue[idx] == q)
                            {
                                idx = r.Next(0, l - 1);
                                check = 1;
                                z = y;
                            }
                            else
                            {
                                check = 0;
                            }
                        }
                    }
                }
                x[y] = idx;
                y++;
                int k = 0;
                string temp = "";
                int len = listvalue[idx].Length;
                while (listvalue[idx][k] != '-')
                {
                    k++;
                }
                if (listvalue[idx][k] == '-')
                {
                    k++;
                    int check = 1;
                    while (check == 1 && k<len)
                    {
                        if (listvalue[idx][k] != '=' && listvalue[idx][k] != '*' && (listvalue[idx][k] != '-' || listvalue[idx][k+1] != ' '))
                        {
                            temp = temp + listvalue[idx][k];
                            k++;
                        }
                        else
                        {
                            check = 0;
                        }
                    }
                }
                if (i == 0)
                {
                    rb1.Text = temp;
                }
                else if (i == 1)
                {
                    rb2.Text = temp;
                }
                else
                {
                    rb3.Text = temp;
                }
            }
        }
    }
}
