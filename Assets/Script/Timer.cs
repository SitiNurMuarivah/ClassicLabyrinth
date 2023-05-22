using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public string LevelToLoad;
    private float timer = 5f;
    private Text timerSeconds;


    // Use this for initialization
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f1");
        if (timer <= 0)
        {
            SceneManager.LoadScene(LevelToLoad);
        }

    }
}
