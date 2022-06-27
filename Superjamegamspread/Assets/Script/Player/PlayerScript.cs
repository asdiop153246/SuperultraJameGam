using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    private int maxHealthPoint = 100;
    private int currenetHealthPoint = 100;
    private int maxEnergyPoint = 100;
    private int currentEnergyPoint = 100;

    public float timeCount = 5;
    public Text timeText;

    private StatusBarScript statusBar;

    private void Awake()
    {
        statusBar = GetComponent<StatusBarScript>();
    }

    // Start is called before the first frame update
    void Start()
    {
        currenetHealthPoint = maxHealthPoint;
        statusBar.SetMaxHealth(maxHealthPoint);
        currentEnergyPoint = maxEnergyPoint;
        statusBar.SetMaxEnergy(maxEnergyPoint);
        InvokeRepeating("TimeCountDown", 1.0f, 1.0f);

    }

    private void Update()
    {
        timeText.text = "" + timeCount;
        
    }

    public void TakeDamage(int damage)
    {
        currenetHealthPoint -= damage;
        statusBar.SetHealth(currenetHealthPoint);
    }

    void TimeCountDown()
    {
        if (timeCount > 0)
        {
            timeCount -= 1;
        }
        else
        {
            timeCount = 0;
        }
    }

}
