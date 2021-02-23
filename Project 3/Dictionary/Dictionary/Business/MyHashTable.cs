using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Dictionary.Business
{
    class MyHashTable
    {
        //Properties
        public static int N = Convert.ToInt32(SIZE.N);
        public LINKEDLIST[] HT = new LINKEDLIST[N];
        //Method
        //Hàm khởi tạo mảng băm
        public void InitHashTable()
        {
            for (int i = 0; i < HT.Count();i++ )
            {
                HT[i] = new LINKEDLIST();
                HT[i].InitList();
            }
        }
        //Hàm khởi tạo một từ điển
        public Node CreateNode(string key, string value)
        {
            Node p = new Node();
            p.key = key;
            p.value = value;
            p.pNext = null;
            return p;
        }
        //Hàm băm
        private int HashFunction(string key)
        {
            int k = 0;
            for (int i = 0; i < key.Length; i++)
                k = k + key[i] - 48;
            return k % N;
        }
        //Hàm thêm một key-value vào mảng băm
        public void AddKey(string key, string value)
        {
            int address = HashFunction(key);
            Node p = CreateNode(key, value);
            HT[address].AddLast(p);
        }
        //Hàm tìm một value dựa theo key
        public Node SearchKey(string key)
        {
            int address = HashFunction(key);
            return HT[address].SearchNode(key);
        }
        //Hàm remove key
        public void RemoveKey(string key)
        {
            int address = HashFunction(key);
            Node q = SearchKey(key);
            HT[address].RemoveNode(q);
        }
    }
}
