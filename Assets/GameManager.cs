using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject enemy1;
    [SerializeField] GameObject enemy2;
    [SerializeField] GameObject enemy3;
    public static GameManager instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        Screen.SetResolution(1920, 1080, true); //Full Screen
        player = GetComponent<GameObject>();
        enemy1 = GetComponent<GameObject>();
        enemy2 = GetComponent<GameObject>();
        enemy3 = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
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
