using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableBinarySearch
{
    public class MyMapNode<K,V>
    {
        public readonly int size;
        public LinkedList<KeyValuePair<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValuePair<K, V>>[size];
        }
        protected int GetArrayPostion(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public V Get(K key)
        {
            int position = GetArrayPostion(key);
            LinkedList<KeyValuePair<K, V>> linkedlist = GetLinkedList(position);
            foreach (KeyValuePair<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        public void Add(K key,V value)
        {
            int position = GetArrayPostion(key);
            LinkedList<KeyValuePair<K, V>> linkedlist = GetLinkedList(position);
            KeyValuePair<K, V> item = new KeyValuePair<K, V>(); 
            linkedlist.AddLast(item);
        }
        public void Remove(K key)
        {
            int position = GetArrayPostion(key);
            LinkedList<KeyValuePair<K, V>> linkedlist = GetLinkedList(position);
            bool itemFound = false;
            KeyValuePair<K, V> founditem = default(KeyValuePair<K, V>);
            foreach (KeyValuePair<K, V> item in linkedlist)
            {
                if(item.Key.Equals(key))
                {
                    itemFound = true;
                    founditem = item;
                }
            }
            if(itemFound)
            {
                linkedlist.Remove(founditem);
            }
        }
        protected LinkedList<KeyValuePair<K,V>> GetLinkedList(int position)
        {
            LinkedList<KeyValuePair<K, V>> linkedlist = items[position];
            if(linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValuePair<K,V>>();
                items[position] = linkedlist;
            }
            return linkedlist;
        }
        public struct KeyValue<k,v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }
    }
}
