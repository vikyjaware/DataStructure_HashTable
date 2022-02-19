using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_HashTable
{
    public struct KeyValue<k, v>
    {
        public k Key { get; set; }
        public v Value { get; set; }
    }

    public class MyMapNode<k, v>
    {
        public int size;
        public LinkedList<KeyValue<k, v>>[] element;

        public MyMapNode(int size)
        {
            this.size = size;
            this.element = new LinkedList<KeyValue<k, v>>[size];
        }

        public LinkedList<KeyValue<k, v>> GetLinkedListElement(int position)
        {
            LinkedList<KeyValue<k, v>> list = element[position];
            if (list == null)
            {
                list = new LinkedList<KeyValue<k, v>>();
                element[position] = list;
            }
            return list;
        }

        public int GetArrayPosition(k key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public v GetElement(k key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<k, v>> list = GetLinkedListElement(position);

            foreach (KeyValue<k, v> item in list)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(v);
        }

        public void RemoveElement(k key)
        {
            int state = GetArrayPosition(key);
            LinkedList<KeyValue<k, v>> list = GetLinkedListElement(state);
            bool elementFound = false;
            KeyValue<k, v> foundElement = default(KeyValue<k, v>);
            foreach (KeyValue<k, v> item in list)
            {
                elementFound = true;
                foundElement = item;
            }
            if (elementFound)
            {
                list.Remove(foundElement);
            }
        }

        public void Add(k key, v value)
        {
            int state = GetArrayPosition(key);
            LinkedList<KeyValue<k, v>> list = GetLinkedListElement(state);
            KeyValue<k, v> element = new KeyValue<k, v>() { Key = key, Value = value };
            list.AddLast(element);
            Console.WriteLine(value);
        }
    }
}
