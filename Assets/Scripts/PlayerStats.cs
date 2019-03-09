using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class PlayerStats
    {
    public float maxHeat;
    public float heat;
    public float maxHP;
    public float hp;
    public float maxHungry;
    public float hungry;
    public float maxTiredness;
    public float tiredness;
    public float maxMood;
    public float mood;
    public PlayerStats()
        {
        maxHeat = 100;
        heat = maxHeat;
        maxHP = 20;
        hp = maxHP;
        maxHungry = 100;
        hungry = maxHungry;
        maxTiredness = 200;
        tiredness = maxTiredness ;
        maxMood = 100;
        mood = maxMood;
        }
    public void HoursChange()
    {
        heat--;
        hungry--;
        tiredness--;
        mood--;
    }
}

