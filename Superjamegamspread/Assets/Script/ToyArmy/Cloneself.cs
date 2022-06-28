using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cloneself : MonoBehaviour
{
    public GameObject toy;
    public PlayerScript Score;
    public void Start()
    {
        Score = GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Score.score <= 10)
        {
            Instantiate(toy, transform.position, transform.rotation);
            StartCoroutine(Cooldown());

        }
    }
    IEnumerator Cooldown()
    {
        Score.score += 1;
        yield return new WaitForSeconds(3f);

    }
}
