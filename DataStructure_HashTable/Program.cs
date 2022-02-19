// See https://aka.ms/new-console-template for more information
using DataStructure_HashTable;

MyMapNode<string, string> hashTable = new MyMapNode<string, string>(5);

hashTable.Add("0", "“Paranoids");
hashTable.Add("1", "are");
hashTable.Add("2", "but");
hashTable.Add("3", "paranoid");
hashTable.Add("4", "because");
hashTable.Add("5", "they");
hashTable.Add("6", "are");
hashTable.Add("7", "paranoid");
hashTable.Add("8", "but");
hashTable.Add("9", "because");
hashTable.Add("10", "they");
hashTable.Add("11", "keep");
hashTable.Add("12", "putting");
hashTable.Add("13", "themselves");
hashTable.Add("14", "deliberately");
hashTable.Add("15", "into");
hashTable.Add("16", "paranoid");
hashTable.Add("17", "avoidable");
hashTable.Add("18", "situations”");

string strHold = hashTable.GetElement("7");
System.Console.WriteLine("7th index value is : " + strHold);