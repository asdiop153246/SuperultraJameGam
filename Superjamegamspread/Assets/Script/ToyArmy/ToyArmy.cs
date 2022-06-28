using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyArmy : MonoBehaviour
{
    private int random;
    private ToyArmyTemplate toyArmyTemplate;

    // Start is called before the first frame update
    void Start()
    {
        toyArmyTemplate = GameObject.FindGameObjectWithTag("ToyArmyTemplate").GetComponent<ToyArmyTemplate>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // if hit human, create toy and destroy human
        if (other.CompareTag("Human"))
        {
            random = Random.Range(0, toyArmyTemplate.toyArmyTemplate.Length);
            Instantiate(toyArmyTemplate.toyArmyTemplate[random], other.transform.position, toyArmyTemplate.toyArmyTemplate[random].transform.rotation);
            Destroy(other.gameObject);
        }
    }
}
