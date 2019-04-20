using System;
using System.Collections.Generic;
using System.Text;

namespace LeastRecentlyUsedAlgorithm_Cache
{
    class DoublyLinkedList
    {
        DoublyLinkedListNode head;
        int size;
        int capacity;

        private DoublyLinkedList() { }

        public DoublyLinkedList(DoublyLinkedListNode doublyLinkedListNode, int capacity) {
            this.capacity = capacity;
            head = doublyLinkedListNode;
        }


        public DoublyLinkedListNode GetDoublyLinkedListNodeHead() {
            return head;
        }

        public void SetDoublyLinkedListNodeHead(DoublyLinkedListNode doublyLinkedListNode) {
            head = doublyLinkedListNode;
        }


        public DoublyLinkedListNode InsertAtFront(DoublyLinkedListNode doublyLinkedListNode,
            int data)
        {
            if (size == capacity) {
                Console.WriteLine("Doubly Linked List is full! Cannot insert!");
                return doublyLinkedListNode;
            }
            
            size++;
            if (doublyLinkedListNode == null) {
                doublyLinkedListNode = new DoublyLinkedListNode(data);
                return doublyLinkedListNode;
            }

            DoublyLinkedListNode doublyLinkedListNodeNew = new DoublyLinkedListNode(data);
            doublyLinkedListNodeNew.SetDoublyLinkedListNodeNext(doublyLinkedListNode);
            doublyLinkedListNode.SetDoublyLinkedListNodePrevious(doublyLinkedListNodeNew);
            doublyLinkedListNode = doublyLinkedListNodeNew;
            return doublyLinkedListNode;
        }

        public DoublyLinkedListNode DeleteLast(DoublyLinkedListNode doublyLinkedListNode) {
            if (doublyLinkedListNode == null) {
                Console.WriteLine("Doubly Linked List is empty! Cannot delete at all!");
                return doublyLinkedListNode ;
            }

            DoublyLinkedListNode newList = doublyLinkedListNode;
            while (newList != null && newList.GetDoublyLinkedListNodeNext() != null) {
                newList = newList.GetDoublyLinkedListNodeNext();
            }
            newList.GetDoublyLinkedListNodePrevious().SetDoublyLinkedListNodeNext(null);
            size--;
            return doublyLinkedListNode;
        }

        public int GetDoublyLinkedListCapacity() {
            return capacity;
        }

        public void SetDoublyLinkedListCapacity(int capacity) {
            this.capacity = capacity;
        }

        public int GetDoublyLinkedListSize() {
            return size;
        }

        public bool isDoublyLinkedListFull() {
            return size == capacity;
        }

        public DoublyLinkedListNode DeleteNode(DoublyLinkedListNode doublyLinkedListNode, int data) {
            if (doublyLinkedListNode == null) {
                Console.WriteLine("The Doubly Linked List is empty! Cannot delete at all!");
                return null; 
            }

            DoublyLinkedListNode toBeDeleted = doublyLinkedListNode;
            while (toBeDeleted != null && toBeDeleted.GetDoublyLinkedListNodeData() != data) {
                toBeDeleted = toBeDeleted.GetDoublyLinkedListNodeNext();
            }

            if (toBeDeleted.GetDoublyLinkedListNodePrevious() != null)
            {
                toBeDeleted.GetDoublyLinkedListNodePrevious()
                    .SetDoublyLinkedListNodeNext(toBeDeleted.GetDoublyLinkedListNodeNext());
            }
            if (toBeDeleted.GetDoublyLinkedListNodeNext() != null)
            {
                toBeDeleted.GetDoublyLinkedListNodeNext()
                    .SetDoublyLinkedListNodePrevious(toBeDeleted.GetDoublyLinkedListNodePrevious());
            }
            size--;
            return doublyLinkedListNode;
        }
    }
}
