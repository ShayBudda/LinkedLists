//Linked-List

using LinkedLists;

LinkedList LinkedList = new LinkedList();
LinkedList.InsertFirst(1);
LinkedList.InsertFirst(2);
LinkedList.InsertFirst(3);
LinkedList.InsertFirst(4);

LinkedList.DeleteFirst();
LinkedList.DeleteFirst();

LinkedList.InsertLast(454);
LinkedList.InsertLast(456);

LinkedList.DisplayList();
// a node is a part of a linked list that includes the element and the reference point
// the first part of a linked list is null. It's like th kaboose of the train
// This code is thanks to Teddy Smith's YouTube Channel