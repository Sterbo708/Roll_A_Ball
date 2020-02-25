using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Countdown : MonoBehaviour
{
     float timeLeft = 45.0f;

    public Text text;



    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "Time Left:" + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}