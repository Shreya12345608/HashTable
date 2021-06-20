using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    //class for KeyValue pair of key and value
    public class KeyValue<K, V>
    {
        // propery for key and value 
        public K Key { get; set; }
        public V Value { get; set; }
    }
}
