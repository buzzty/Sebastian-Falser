using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private int timer;
    [SerializeField] private TextMeshProUGUI timerUGUI;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            timer = 30;
        }
        if (SceneManager.GetActiveScene().name == "Level 2")
        {
            timer = 25;
        }
        if (SceneManager.GetActiveScene().name == "Level 3")
        {
            timer = 20;
        }
        if (SceneManager.GetActiveScene().name == "Level 4")
        {
            timer = 15;
        }

        StartCoroutine(GameTimer());
    }

    private void Update()
    {
        if (timer <= 0)
        {
            timer = 0;
            
            GameEvents.current.StopTimer();
        }
    }

    IEnumerator GameTimer()
    {
        while (timer > 0)
        {
            timerUGUI.text = "Time remaining = " + timer.ToString();
            
            yield return new  WaitForSecondsRealtime(1f);

            timer--;
        }
    }
}
