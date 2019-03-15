using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]


class Consumables:Item
{
        public Consumables(string itemName, string pathToSprite, string pathToPrefab)
    {
        stekCount = 1;
        name = itemName;
        type = "Consumables";
    }
}

