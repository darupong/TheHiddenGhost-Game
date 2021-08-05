using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float timer;
    float seconds;
    float minutes;
    float hours;

    public bool start;

    [SerializeField] Text timerectext;
    // Start is called before the first frame update
    void Start()
    {
        start = true;
        //timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timerecord();
    }

    void timerecord()
    {
        if (start)
        {
            timer += Time.deltaTime;
            seconds = (int)(timer % 60);
            minutes = (int)((timer / 60) % 60);
            hours = (int)(timer / 3600);

            timerectext.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
        }
    }

    public void stopTime()
    {
        start = false;
        Score.score += 100;
        Time.timeScale = 0;
        SceneManager.LoadScene(2);
    }
}
