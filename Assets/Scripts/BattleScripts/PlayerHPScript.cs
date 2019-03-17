using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPScript : MonoBehaviour
{
    public int HP = 100;
    public Text playerHP;
    public Slider slider;
    // Use this for initialization
    void Start()
    {
        playerHP.text = "PlayerHP: " + HP.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Enemy"))
        {
            HP--;
            playerHP.text = "PlayerHP: " + HP.ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        slider.value = HP;
    }
}
