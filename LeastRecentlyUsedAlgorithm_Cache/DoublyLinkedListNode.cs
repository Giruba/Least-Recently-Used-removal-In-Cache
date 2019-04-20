using System;
using System.Collections.Generic;
using System.Text;

namespace LeastRecentlyUsedAlgorithm_Cache
{
    class DoublyLinkedListNode
    {
        int data;
        DoublyLinkedListNode previousNode;
        DoublyLinkedListNode nextNode;

        private DoublyLinkedListNode() { }

        public DoublyLinkedListNode(int data) {
            this.data = data;
        }

        public void SetDoublyLinkedListNodeData(int data) {
            this.data = data;
        }

        public void SetDoublyLinkedListNodePrevious(DoublyLinkedListNode doublyLinkedListNode) {
            previousNode = doublyLinkedListNode;
        }

        public void SetDoublyLinkedListNodeNext(DoublyLinkedListNode doublyLinkedListNode) {
            nextNode = doublyLinkedListNode;
        }

        public int GetDoublyLinkedListNodeData() {
            return data;
        }

        public DoublyLinkedListNode GetDoublyLinkedListNodePrevious() {
            return previousNode;
        }

        public DoublyLinkedListNode GetDoublyLinkedListNodeNext() {
            return nextNode;
        }
    }
}
