using System;
using System.Collections.Generic;
using System.Text;

namespace LeastRecentlyUsedAlgorithm_Cache
{
    class LRUCache
    {
        DoublyLinkedList doublyLinkedList;
        Dictionary<int, DoublyLinkedListNode> hashMap = new Dictionary<int, DoublyLinkedListNode>();


        private LRUCache() { }

        public LRUCache(int sizeofDLL) {
            doublyLinkedList = new DoublyLinkedList(null, sizeofDLL);
        }

        public int GetLRUCacheMemorySize() {
            return doublyLinkedList.GetDoublyLinkedListSize();
        }

        public DoublyLinkedList GetLRUCacheDoublyLinkedList() {
            return doublyLinkedList;
        }

        public IDictionary<int, DoublyLinkedListNode> GetLRUCacheHashMap() {
            return hashMap;
        }


        public void SetLRUCacheDoublyLinkedList(DoublyLinkedList doublyLinkedList)
        {
            this.doublyLinkedList = doublyLinkedList;
        }

        public void GetLRUCacheHashMap(Dictionary<int, DoublyLinkedListNode> hashMap)
        {
            this.hashMap = hashMap;
        }

        public void PrintCacheElements(DoublyLinkedList doublyLinkedList) {
            if (doublyLinkedList == null)
            {
                Console.WriteLine("The Doubly Linked List is empty!" +
                    " Cannot print any element :)");
            }
            else {
                DoublyLinkedListNode doublyLinkedListNode =
                    doublyLinkedList.GetDoublyLinkedListNodeHead();
                if (doublyLinkedListNode == null) {
                    Console.WriteLine("The head of the Doubly linked list is empty!");
                    return;
                }
                Console.WriteLine("Printing elements in the cache memory------");
                while (doublyLinkedListNode != null) {
                    Console.Write(doublyLinkedListNode.GetDoublyLinkedListNodeData()
                        +" ");
                    doublyLinkedListNode = doublyLinkedListNode.GetDoublyLinkedListNodeNext();
                }
            }
            Console.WriteLine();
        }

        public void ReferPageInLRUCache(int data) {
            if (!hashMap.ContainsKey(data))
            {
                Console.WriteLine("The entered element is not present in the HashMap!");
                if (doublyLinkedList != null && doublyLinkedList.isDoublyLinkedListFull())
                {
                    Console.WriteLine("Cache memory is full! Making way for the new" +
                        " element by deleting the least recently used" +
                        " element at the last");                    
                    doublyLinkedList.SetDoublyLinkedListNodeHead(
                        doublyLinkedList.DeleteLast(doublyLinkedList.GetDoublyLinkedListNodeHead()));
                }
                if (doublyLinkedList != null && doublyLinkedList.GetDoublyLinkedListSize() <
                        doublyLinkedList.GetDoublyLinkedListCapacity()) {                     

                        Console.WriteLine("Cache memory is empty! Adding the element");
                }
                doublyLinkedList.SetDoublyLinkedListNodeHead(
                    doublyLinkedList.InsertAtFront(doublyLinkedList.GetDoublyLinkedListNodeHead(),
                    data)
                    );
                hashMap.Add(data, doublyLinkedList.GetDoublyLinkedListNodeHead());
                    
            }            
            else {
                Console.WriteLine("The element is present! Bringing it to the front...");
                doublyLinkedList.SetDoublyLinkedListNodeHead(
                doublyLinkedList.DeleteNode(doublyLinkedList.GetDoublyLinkedListNodeHead(),data));
                hashMap.Remove(data);
                doublyLinkedList.SetDoublyLinkedListNodeHead(
                doublyLinkedList.InsertAtFront(doublyLinkedList.GetDoublyLinkedListNodeHead(),data));
                hashMap[data] =  doublyLinkedList.GetDoublyLinkedListNodeHead();
            }
        }
    }
}
