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

    private bool isPlaying;

    public GameObject gameOverCanvas;
    public GameObject gameWinCanvas;

    public float timeCount = 5;
    public Text timeText;
    public Text scoreText;
    private int score = 0;

    private StatusBarScript statusBar;
    private ToyArmyTemplate toyArmyTemplate;

    private void Awake()
    {
        statusBar = GetComponent<StatusBarScript>();
        gameOverCanvas.SetActive(false);
        gameWinCanvas.SetActive(false);
        isPlaying = true;

    }

    // Start is called before the first frame update
    void Start()
    {
        toyArmyTemplate = GameObject.FindGameObjectWithTag("ToyArmyTemplate").GetComponent<ToyArmyTemplate>();

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

        // Show score
        scoreText.text = "Score " + score + " / " + 60;

        // Update score
        if(toyArmyTemplate.toyArmyList.Count <= 0)
        {
            score = 0;
        }
        else
        {
            score = toyArmyTemplate.toyArmyList.Count;
        }

        if (score == 60)
        {
            isPlaying = false;
            gameWinCanvas.SetActive(true);
        }
        
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
        if (timeCount > 0 && isPlaying == true)
        {
            timeCount -= 1;
        }
        // Time out
        else if (timeCount >= 0 && isPlaying == true)
        {
            timeCount = 0;
            gameOverCanvas.SetActive(true);
        }
        else if (timeCount > 0 && isPlaying == false)
        {
            gameOverCanvas.SetActive(true);
        }
    }

}
