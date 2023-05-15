using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingController : MonoBehaviour
{
    [SerializeField] Text endingText;
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        endingText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }

    }
    void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
      UnityEngine.Application.Quit();
#endif
    }
}
