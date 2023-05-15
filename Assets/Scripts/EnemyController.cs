using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private new Rigidbody rigidbody = new Rigidbody();
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        //Enemy N0.2
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
        //Enemy N0.3
        if (collision.transform.tag == "Player" && gameObject.tag == "Enemy3")
        {
            score += 1000;
            Destroy(gameObject);
        }
        else if (collision.transform.tag == "SecondFloor" && gameObject.tag == "Enemy3")
        {
            score += 1000;
            Destroy(gameObject);
        }

    }
}
