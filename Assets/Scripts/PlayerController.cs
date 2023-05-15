using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private new Rigidbody rigidbody = new Rigidbody();
    [SerializeField] private float power;
    private bool touchDown;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        power = 50;
        touchDown = false;
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            rigidbody.velocity = new Vector3(1, 0, 0) * power;
        }

        //Left movement
        if (Input.GetKey(KeyCode.LeftArrow) && gameObject.tag == "Player")
        {
            rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
        }
        
        if(touchDown)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("EndingScene");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Ground")
        {
            touchDown = true;
            transform.position = startPosition;
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
    }
    public bool GetTouchDown()
    {
        return touchDown;
    }
}
