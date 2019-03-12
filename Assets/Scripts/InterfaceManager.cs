﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField] GameObject craftTypes;
    [SerializeField] Image hpBar;
    [SerializeField] Image hungryBar;
    [SerializeField] Image heatBar;
    [SerializeField] Image tirednessBar;
    [SerializeField] Image moodBar;
    private bool openCraft;
    private GameObject craftTypeView;
    private void Update()
    {
        hpBar.fillAmount = PlayerManager.playerStats.hp / PlayerManager.playerStats.maxHP;
        hungryBar.fillAmount = PlayerManager.playerStats.hungry / PlayerManager.playerStats.maxHungry;
        heatBar.fillAmount = PlayerManager.playerStats.heat / PlayerManager.playerStats.maxHeat;
        tirednessBar.fillAmount = PlayerManager.playerStats.tiredness / PlayerManager.playerStats.maxTiredness;
        moodBar.fillAmount = PlayerManager.playerStats.mood / PlayerManager.playerStats.maxMood;
    }
    public void OpenCraft()
    {
        craftTypes.SetActive (!craftTypes.activeSelf);
    }
    public void CraftType(string typeName)
    {
        craftTypeView = Resources.Load<GameObject>("Craft/" + typeName);
        craftTypeView = Instantiate(craftTypeView,craftTypes.transform);
    }
}
