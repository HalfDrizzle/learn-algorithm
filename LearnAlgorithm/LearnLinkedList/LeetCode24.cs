using System;

namespace LearnAlgorithm.LearnLinkedList;

public class LeetCode24
{
    public LeetCode24()
    {
        var listNode = AddListNode();

        Print(SwapPairs(listNode));
    }

    public ListNode AddListNode()
    {
        var data = new int[] { 1, 2, 3, 4 };
        ListNode list = new ListNode();
        var tail = list;
        for (int i = 0; i < data.Length; i++)
        {
            tail.next = new ListNode(data[i]);
            tail = tail.next;
        }
        return list.next;
    }

    public void Print(ListNode listNode)
    {
        var cur = listNode;
        while (cur.next == null)
        {
            Console.Write(cur.val + ",");
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode SwapPairs(ListNode head)
    {
        if (head?.next == null)
        {
            return head;
        }
        var dummyNode = new ListNode(0, head);

        var cur = head;
        var pre = dummyNode;
        var end = cur.next;
        while (end != null)
        {
            var tmp = end.next;
            end.next = cur;
            cur.next = tmp;
            pre.next = end;


            if (tmp == null)
            {
                break;
            }

            pre = cur;
            cur = tmp;
            end = tmp.next;
        }

        return dummyNode.next;
    }
}