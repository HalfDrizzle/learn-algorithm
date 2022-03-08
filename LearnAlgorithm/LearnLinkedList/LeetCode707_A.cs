using System;

namespace LearnAlgorithm.LearnLinkedList
{
    public class LinkedList
    {
        public LinkedList()
        {
            MyLinkedList obj = new MyLinkedList();

            obj.AddAtHead(1);
            obj.AddAtTail(3);
            obj.AddAtIndex(1,2);
            int param_1 = obj.Get(1);
            Console.WriteLine(param_1);
            obj.DeleteAtIndex(1);
            param_1 = obj.Get(1);
            Console.WriteLine(param_1);
        }
        
        public class NodeList
        {
            public NodeList next;
            public int val;

            public NodeList(int val, NodeList next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class MyLinkedList
        {
            private NodeList _dummyNode;
            private int _size;

            public MyLinkedList()
            {
                _dummyNode = new NodeList(0);
                _size = 0;
            }

            public int Get(int index)
            {
                if (index < 0 || index >= _size)
                {
                    return -1;
                }

                var node = _dummyNode;
                for (int i = 0; i <= index; i++)
                {
                    node = node.next;
                }

                return node.val;
            }

            public void AddAtHead(int val)
            {
                AddAtIndex(0, val);
            }

            public void AddAtTail(int val)
            {
                AddAtIndex(_size, val);
            }

            public void AddAtIndex(int index, int val)
            {
                if (index > _size)
                {
                    return;
                }

                if (index < 0)
                {
                    AddAtHead(val);
                    return;
                }

                var predNode = _dummyNode;
                _size++;
                for (int j = 0; j < index; j++)
                {
                    predNode = predNode.next;
                }

                predNode.next = new NodeList(val, predNode.next);
            }

            public void DeleteAtIndex(int index)
            {
                if (index < 0 || index >= _size)
                {
                    return;
                }

                var checkNode = _dummyNode;
                for (int i = 0; i < index; i++)
                {
                    checkNode = checkNode.next;
                }

                checkNode.next = checkNode.next.next;
                _size--;
            }
        }

        /**
         * Your MyLinkedList object will be instantiated and called as such:
         * MyLinkedList obj = new MyLinkedList();
         * int param_1 = obj.Get(index);
         * obj.AddAtHead(val);
         * obj.AddAtTail(val);
         * obj.AddAtIndex(index,val);
         * obj.DeleteAtIndex(index);
         */
    }
}