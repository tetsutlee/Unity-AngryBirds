using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig3Controller : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        //Enemy N0.1
        if (collision.transform.tag == "Player" && gameObject.tag == "Enemy2")
        {
            score += 1000;
            Destroy(gameObject);
        }
        else if (collision.transform.tag == "SecondFloor" && gameObject.tag == "Enemy2")
        {
            score += 1000;
            Destroy(gameObject);
        }
    }
}
