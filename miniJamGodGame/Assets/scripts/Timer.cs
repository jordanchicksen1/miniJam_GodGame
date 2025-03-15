using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float currentTime;
    public float maxTime = 5f;
    public Image TimerBar;

    public GameObject nextQuestion;
    public GameObject currentQuestion;

    public void updateTime(float amount)
    {
        currentTime += amount;
        updateTimeBar();
        Debug.Log("should decrease");
    }

    public void Update()
    {
        currentTime -= Time.deltaTime;
        updateTimeBar();
        nextQ();
    }

    public void updateTimeBar()
    {
        float targetFillAmount = currentTime / maxTime;
        TimerBar.fillAmount = targetFillAmount;
    }

    public void nextQ() 
    {
        if (currentTime <= 0 ) 
        {
            Debug.Log("0");
            currentQuestion.SetActive(false);
            nextQuestion.SetActive(true);
        }
    }
}
