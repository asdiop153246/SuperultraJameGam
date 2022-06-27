using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusBarScript : MonoBehaviour
{
    public Slider healthSlider;
    public Slider energySlider;

    public void SetMaxHealth(int Health)
    {
        healthSlider.maxValue = Health;
        healthSlider.value = Health;
    }

    public void SetHealth(int Health)
    {
        healthSlider.value = Health;
    }

    public void SetMaxEnergy(int Energy)
    {
        energySlider.maxValue = Energy;
        energySlider.value = Energy;
    }

    public void SetEnergy(int Energy)
    {
        energySlider.value = Energy;
    }
}
