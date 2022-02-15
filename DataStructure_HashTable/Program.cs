// See https://aka.ms/new-console-template for more information
using DataStructure_HashTable;

MyMapNode<string, string> hashTable = new MyMapNode<string, string>(5);

hashTable.Add("0", "To");
hashTable.Add("1", "be");
hashTable.Add("2", "or");
hashTable.Add("3", "not");
hashTable.Add("4", "to");
hashTable.Add("5", "be");

string strHold = hashTable.GetElement("0");
System.Console.WriteLine("4th index value is : " + strHold);