using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 500.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x * speed * Time.deltaTime, 0, 0);

        float z = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, 0, z * speed * Time.deltaTime);
    }
}
