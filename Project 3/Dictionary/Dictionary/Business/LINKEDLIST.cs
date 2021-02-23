using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Business
{
    class LINKEDLIST 
    {
        //Properties
        public Node pHead;
        public Node pTail;
        //Method
        public void InitList()
        {
            pHead = pTail = null;
        }
        public bool IsEmptyList()
        {
            if (pHead == null)
                return true;
            return false;
        }
        public void AddFirst(Node p)
        {
            if (pHead == pTail)
                pHead = pTail = p;
            else
            {
                p.pNext = pHead;
                pHead = p;
            }
        }
        public void AddLast(Node p)
        {
            if (pHead == null)
                pHead = pTail = p;
            else
            {
                pTail.pNext = p;
                pTail = p;
            }
        }
        public void RemoveFist()
        {
            if (!IsEmptyList())
            {
                Node p = pHead;
                pHead = pHead.pNext;

            }
        }
        public void RemoveLast()
        {
            if (!IsEmptyList())
            {
                if (pHead == pTail)
                    pHead = pTail = null;
                else
                {
                    Node p = pHead;
                    for (; p.pNext != pTail; p = p.pNext) ;
                    p.pNext = null;
                    pTail = p;  
                }

            }
        }
        public void RemoveAfter(Node q)
        {
            Node temp = q.pNext;
            q.pNext = temp.pNext;
            if (q.pNext == null)
                pTail = q;
        }
        public void RemoveNode(Node q)
        {
            if (!IsEmptyList())
            {
                if (pHead == q)
                    RemoveFist();
                else if (pTail == q)
                    RemoveLast();
                else
                {
                    Node p = pHead;
                    for (; p.pNext != q; p = p.pNext) ;
                    RemoveAfter(p);
                }
            }
        }
        public Node SearchNode(string value)
        {
            for (Node p = pHead; p != null; p = p.pNext)
                if (Compare(p.key,value))
                    return p;
            return null;
        }
        private bool Compare(string x, string y)
        {
            x = x.Trim();
            y = y.Trim();
            return String.Compare(x, y, true) == 0;
        }
    }
}
