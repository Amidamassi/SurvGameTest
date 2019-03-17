using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

    class Weapon:Item
    {
    public int damage;
    public int atackRange;
    public Weapon(string itemName, int atackdamage)
    {
        stekCount = 1;
        name = itemName;
        type = "Weapon";
        damage = atackdamage;
        atackRange = 1;
    }
    public Weapon(string itemName, int atackdamage,int rangeOfAtack)
    {
        stekCount = 1;
        name = itemName;
        type = "Weapon";
        damage = atackdamage;
        atackRange = rangeOfAtack;
    }
}

