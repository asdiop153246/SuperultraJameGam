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

    }

    public void TakeDamage(int damage)
    {
        currenetHealthPoint -= damage;
        statusBar.SetHealth(currenetHealthPoint);
    }

}
