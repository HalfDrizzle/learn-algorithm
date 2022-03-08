
public class DoubleLinkedList
{
    public class NodeList
    {
        public NodeList next;
        public NodeList pred;
        public int val;

        public NodeList(int val, NodeList pred = null, NodeList next = null)
        {
            this.val = val;
            this.pred = pred;
            this.next = next;
        }
    }

    public class MyLinkedList
    {
        private NodeList head;
        private NodeList tail;
        private int _size;

        public MyLinkedList()
        {
            head = new NodeList(0);
            tail = new NodeList(0);
            head.next = tail;
            tail.pred = head;
            _size = 0;
        }

        public int Get(int index)
        {
            if (index < 0 || index >= _size)
            {
                return -1;
            }


            if (index > _size / 2)
            {
                var node = tail;
                for (int i = _size; i >= index; i++)
                {
                    node = node.next;
                }
                return node.val;
            }
            else
            {
                var node = head;
                for (int i = 0; i <= index; i++)
                {
                    node = node.next;
                }
                return node.val;
            }
        }

        public void AddAtHead(int val)
        {
            AddAtIndex(0,val);
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

            _size++;
            if (index > _size / 2)
            {
                var predNode = tail;
                for (int j = _size; j > index; j++)
                {
                    predNode = predNode.next;
                }
                predNode.next = new NodeList(val, predNode.next);
            }
            else
            {
                var predNode = head;
                for (int j = 0; j < index; j++)
                {
                    predNode = predNode.next;
                }
                predNode.next = new NodeList(val, predNode.next);
            }

        }

        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= _size)
            {
                return;
            }

            var checkNode = ;
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
