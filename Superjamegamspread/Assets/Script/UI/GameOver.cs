using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public Controller controller;

    // Start is called before the first frame update
    void Start()
    {
        controller.GetComponent<Controller>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
