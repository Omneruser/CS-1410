// Omner Allen
// Lab2
// Sep. 7, 2021
// I used Adam Teichert's starter code.


using System;
using System.Collections.Generic;
using System.Diagnostics;

// represents a prioritized item on a to-do list
class ToDoItem
{
    // short description of the item
    private string _name;

    // bigger number means the item is more important
    private decimal _importance;

    public string GetName()
    {
        return _name;
    }

    public decimal GetImportance()
    {
        return _importance;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetImportance(decimal importance)
    {
        _importance = importance;
    }

}

// represents a to-do list
class ToDoList
{
   
    // holds the pending items
    private List<ToDoItem> _items = new List<ToDoItem>();

    // adds the given item to the to-do list
    public void AddItem(string name, decimal importance) {
        ToDoItem item = new ToDoItem();
        item.SetImportance(importance);
        item.SetName(name);
        _items.Add(item);
    }

    // removes the most important item from the list
    public void RemoveTopItem() {
        // TODO: fix this
    }

    // returns the most important item on the list (it is not removed)
    public ToDoItem GetTopItem() {
        // TODO: fix this
        return _items[0];
    }

    // returns the number of pending items on the todo list
    public int GetLength() {
        // TODO: fix this
        return -1;
    }


}

class Program
{
   static void main(){
      RunTests();
      

   }
    static void RunTests()
    {
        ToDoList MyToDoList = new ToDoList();
        MyToDoList.AddItem("first item", 2);
        Debug.Assert(MyToDoList.GetTopItem().GetImportance() == 2 );
    }
}






