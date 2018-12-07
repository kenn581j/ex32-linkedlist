using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex32_linkedlist
{
    public class MyLinkedList
    {
        private int count;
        public int Count
        {
            get => count;
            set { count = value; }
        }
        private Node Head = new Node();

        public void Insert(object clubMember)
        {
            Insert(clubMember, 0);
        }

        public void Insert(object clubMember, int index)
        {
            if(index > Count)
            {
                throw new IndexOutOfRangeException();
            }

            Node n = new Node();
            n.Data = clubMember;

            if (index == 0)
            {
                n.Next = Head;
                Head = n;
                Count++;
            }
            else
            {
                Node pegepind = Head;
                Node previous = null;

                for (int i = 0; i < index; i++)
                {
                    previous = pegepind;
                    pegepind = pegepind.Next;
                }
                previous.Next = n;
                n.Next = pegepind;
                Count++;
            }
        }

        public override string ToString()
        {
            string v = "";
            Node Pegepind;
            Pegepind = Head;

            for (int i = 0; i < Count; i++)
            {
                v += Pegepind.Data.ToString();
                Pegepind = Pegepind.Next;
            }

            return v;
        }

        public void Delete()
        {
            Delete(0);
        }
        public void Delete(int index)
        {
            if (index > Count)
            {
                throw new IndexOutOfRangeException();
            }

            Node pegepind;
            
            if(index == 0)
            {
                pegepind = Head.Next;
                Head = pegepind;
                Count--;
            }
            else
            {
                pegepind = Head;
                Node previous;
                for (int i = 0; i < index; i++)
                {
                    previous = pegepind;
                    pegepind = pegepind.Next;
                }

                previous = pegepind.Next;
                pegepind.Next = null;
                count--;
            }
                    
            
           
        }
        
        public object ItemAt(int index)
        {
            Node Pegepind;
            Pegepind = Head;
            object v = Pegepind.Data;          
            for (int i = 0; i < index; i++)
            {
                Pegepind = Pegepind.Next;
                v = Pegepind.Data;                               
            }          
            
            return v;
        }

    }
    class Node
    {
        private object data;
        private Node next;
        public object Data
        {
            get => data;
            set { data = value; }
        }
        public Node Next
        {
            get => next;
            set { next = value; }
        }
    }
}
