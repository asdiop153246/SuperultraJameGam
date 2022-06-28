using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnrocket : MonoBehaviour
{
    public GameObject Rocket;
    public float time = 0.0f;
    public float repeatRate = 3.0f;
    
    void Start()
    {
        InvokeRepeating("Spawn",time,repeatRate);       
    }
   
    public void Spawn()
    {
        Instantiate(Rocket, new Vector3(Random.Range(-9,9), 7.5f , 0), Quaternion.identity);
        /*private void name(name player)
        Namefile player = hitinfo.GetComponent<Move_character>();
        if (player != null){
        player.TargetDamage();*/
    }
}
    
