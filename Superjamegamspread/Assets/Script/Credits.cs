using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public GameObject settingMenu;

    private void Start()
    {
        settingMenu.SetActive(false);

    }

    public void OpenSettingMenu()
    {
        settingMenu.SetActive(true);
    }

    public void CloseSettingMenu()
    {
        settingMenu.SetActive(false);
    }
}
