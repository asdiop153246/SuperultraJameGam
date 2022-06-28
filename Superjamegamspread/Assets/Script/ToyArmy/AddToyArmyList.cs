using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToyArmyList : MonoBehaviour
{
    private ToyArmyTemplate toyArmyTemplate;

    // Start is called before the first frame update
    void Start()
    {
        toyArmyTemplate = GameObject.FindGameObjectWithTag("ToyArmyTemplate").GetComponent<ToyArmyTemplate>();
        toyArmyTemplate.toyArmyList.Add(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
