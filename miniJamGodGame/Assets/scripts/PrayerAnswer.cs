using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrayerAnswer : MonoBehaviour
{
    public PlayerData playerData;
    public Timer timer;

    [Header("Question 1")]
    public GameObject Q1;

    [Header("Question 2")]
    public GameObject Q2;

    [Header("Question 3")]
    public GameObject Q3;

    [Header("Question 4")]
    public GameObject Q4;

    [Header("Question 5")]
    public GameObject Q5;

    [Header("Question 6")]
    public GameObject Q6;

    [Header("Question 7")]
    public GameObject Q7;

    [Header("Question 8")]
    public GameObject Q8;

    [Header("Question 9")]
    public GameObject Q9;

    [Header("Question 10")]
    public GameObject Q10;

    public void Update()
    {
        
    }

    public void Q1Green() 
    {
        playerData.followers += 50;
        Q1.SetActive(false);
        Q2.SetActive(true);
    }

    public void Q1Red() 
    {
        playerData.followers -= 50;
        Q1.SetActive(false);
        Q2.SetActive(true);
    }



    public void Q2Green()
    {
        playerData.followers -= 20;
        Q2.SetActive(false);
        Q3.SetActive(true);
    }

    public void Q2Red()
    {
        playerData.followers += 30;
        Q2.SetActive(false);
        Q3.SetActive(true);
    }

    public void Q3Green()
    {
        playerData.followers += 50;
        Q3.SetActive(false);
        Q4.SetActive(true);
    }

    public void Q3Red()
    {
        playerData.followers -= 50;
        Q3.SetActive(false);
        Q4.SetActive(true);

    }

    public void Q4Green()
    {
        playerData.followers += 50;
        Q4.SetActive(false);
        Q5.SetActive(true);
    }

    public void Q4Red()
    {
        playerData.followers -= 50;
        Q4.SetActive(false);
        Q5.SetActive(true);
    }

    public void Q5Green()
    {
        playerData.followers += 50;
        Q5.SetActive(false);
        Q6.SetActive(true);
    }

    public void Q5Red()
    {
        playerData.followers -= 50;
        Q5.SetActive(false);
        Q6.SetActive(true);
    }

    public void Q6Green()
    {
        playerData.followers += 50;
        Q6.SetActive(false);
        Q7.SetActive(true);
    }

    public void Q6Red()
    {
        playerData.followers -= 50;
        Q6.SetActive(false);
        Q7.SetActive(true);
    }

    public void Q7Green()
    {
        playerData.followers += 50;
        Q7.SetActive(false);
        Q8.SetActive(true);
    }

    public void Q7Red()
    {
        playerData.followers -= 50;
        Q7.SetActive(false);
        Q8.SetActive(true);
    }

    public void Q8Green()
    {
        playerData.followers += 50;
        Q8.SetActive(false);
        Q9.SetActive(true);
    }

    public void Q8Red()
    {
        playerData.followers -= 50;
        Q8.SetActive(false);
        Q9.SetActive(true);
    }

    public void Q9Green()
    {
        playerData.followers += 50;
        Q9.SetActive(false);
        Q10.SetActive(true);
    }

    public void Q9Red()
    {
        playerData.followers -= 50;
        Q9.SetActive(false);
        Q10.SetActive(true);
    }


    public void Q10Green()
    {
        playerData.followers += 50;
        Q10.SetActive(false);
      
    }

    public void Q10Red()
    {
        playerData.followers -= 50;
        Q10.SetActive(false);
     
    }
}
