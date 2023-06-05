using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class MyLinkedListNode<K,V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
        public MyLinkedListNode<K, V> Next { get; set; }

        public MyLinkedListNode(K key, V value)
        {
            Key = key;
            Value = value;
        }
    }
}
