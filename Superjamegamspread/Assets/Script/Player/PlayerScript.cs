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

    public GameObject gameOverCanvas;

    public float timeCount = 5;
    public Text timeText;

    private StatusBarScript statusBar;

    private void Awake()
    {
        statusBar = GetComponent<StatusBarScript>();
        gameOverCanvas.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        // set HealthPoint and EnergyPoint
        currenetHealthPoint = maxHealthPoint;
        statusBar.SetMaxHealth(maxHealthPoint);
        currentEnergyPoint = maxEnergyPoint;
        statusBar.SetMaxEnergy(maxEnergyPoint);

        // Time countdown
        InvokeRepeating("TimeCountDown", 1.0f, 1.0f);

    }

    private void Update()
    {
        // Show time
        timeText.text = "" + timeCount;
        
    }

    // Player take damage
    public void TakeDamage(int damage)
    {
        // Set health bar
        currenetHealthPoint -= damage;
        statusBar.SetHealth(currenetHealthPoint);
    }

    public void UseEnergy(int energy)
    {
        currentEnergyPoint -= energy;
        statusBar.SetEnergy(currentEnergyPoint);
    }

    void TimeCountDown()
    {
        if (timeCount > 0)
        {
            timeCount -= 1;
        }

        // Time out
        else
        {
            timeCount = 0;
            gameOverCanvas.SetActive(true);
        }
    }

}
