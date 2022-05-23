using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAlgorithm
{
    public interface ILinkedList
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value); // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению
    }

    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }

    public class LinkedList<T>
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int count { get; set; }

        public LinkedList(int value)
        {
            Node item = new Node(value);
            Head = item;
            Tail = item;
            count = 1;
        }

        public int GetCount()
        {
            return count;
        }

        public void AddNode(int value)
        {
            Node item = new Node(value);
            Tail.NextNode = item;
            item.PrevNode = Tail;
            Tail = item;
            count++;
        }

        public void AddNodeAfter(Node node, int value)
        {
            Node item = new Node(value);
            Node current = Head;

            while (current != null)
            {
                if (current.Value.Equals(node))
                {
                    current.NextNode.PrevNode = item;
                    current.NextNode = item;
                    count++;
                }
            }
        }
        public void RemoveNode(int index)
        {

            int currentIndex = 0;
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (currentIndex == index - 1)
                {
                    currentNode.NextNode = currentNode.NextNode.NextNode;
                    currentNode.NextNode.NextNode.PrevNode = currentNode;
                    count--;
                    return;
                }
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

        }
        public void RemoveNode(Node node)
        {
            Node current = Head;

            while (current != null)
            {
                if(current.Value.Equals(node))
                {
                    current.PrevNode.NextNode = current.NextNode;
                    current.NextNode.PrevNode = current.PrevNode;
                    count--;
                    return;
                }
            }

            current = current.NextNode;
        }
        public Node FindNode(int searchValue)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value == searchValue)
                    return currentNode;
                currentNode = currentNode.NextNode;
            }
            return null;
        }
    }
}
