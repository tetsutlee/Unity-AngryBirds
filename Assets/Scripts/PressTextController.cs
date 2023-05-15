using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressTextController : MonoBehaviour
{
    private Text pressText;
    private short time;

    // Start is called before the first frame update
    void Start()
    {
        pressText = GetComponent<Text>();
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        if(time % 30 == 0)
        {
            pressText.text = "Press Space";
        }
        if (time % 60 == 0)
        {
            pressText.text = "   ";
        }
    }
}
