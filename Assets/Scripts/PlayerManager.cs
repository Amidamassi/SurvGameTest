using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerStats playerStats  { get; set;}
    private void Awake()
    {
        playerStats = new PlayerStats();
    }
   
}

