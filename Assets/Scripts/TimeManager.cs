using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TimeManager : MonoBehaviour
{
    [SerializeField] Text date;
    private float time;
    private int prevHours;
    private int prevDays;   
    public int hours { get; private set; }
    public int minutes { get; private set; }
    public int days { get; private set; }
    private void FixedUpdate()
    {
        time = Time.realtimeSinceStartup;
        days = (int)time / 480;
        hours = (int)(time - days * 480) / 20;
        minutes = (int)(time - days * 480 - hours * 20) * 3;
        date.text = "Days: " + days + " Time " + hours + ":" + minutes;
        if (prevHours < hours)
        {
            PlayerManager.playerStats.HoursChange();
            prevHours = hours;
        }
    }
}
