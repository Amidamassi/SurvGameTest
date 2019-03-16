using UnityEngine;
using System.Collections;

public class InventoryManager : MonoBehaviour
{
    public static Item[] items { get; set; }
    private void Awake()
    {
        items = new Item[10];
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = new Item();
            items[i].name = "Empty";
            items[i].type = "Item";
        }
    }
    public void addItem(string name)
    {
        if (EmptySlot())
        {
            FirstEmptySlot().name = name;
        }
    }
    public bool EmptySlot()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i].name == "Empty") { return true; }
        }
        return false;

    }
    public Item FirstEmptySlot()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i].name == "Empty") { return items[i]; }
        }
        return items[0];
    }
}
