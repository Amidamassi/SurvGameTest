using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class AllItems
    {
    public Item[] allItems;
    private List<Item> allItemsList=new List<Item>();
    public AllItems()
    {
        allItemsList.Add(new Weapon("Axe", 1));
        allItemsList.Add(new Weapon("Club", 1));
        allItemsList.Add(new Buildings("Tent"));
        allItemsList.Add(new Buildings("Box"));
        allItemsList.Add(new Res("Wood", 3));

    }
    }

