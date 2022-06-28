using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public PlayerScript playerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerScript.GetComponent<PlayerScript>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
