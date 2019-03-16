using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

class Res:Item
    {
    public Res(string itemName,int countInStek)
    {
        stekCount = countInStek;
        name = itemName;
        type = "Res";
    }
}

