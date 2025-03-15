using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startScript : MonoBehaviour
{
    public GameObject title;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject startButton;
    public GameObject quitButton;


    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        StartCoroutine(TextCrawl());
    }

    public IEnumerator TextCrawl()
    {
        yield return new WaitForSeconds(1f);
        title.SetActive(false);
        startButton.SetActive(false);
        quitButton.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        text1.SetActive(true);
        yield return new WaitForSeconds(5f);
        text2.SetActive(true);
        text1.SetActive(false);
        yield return new WaitForSeconds(7f);
        text3.SetActive(true);
        text2.SetActive(false);
        yield return new WaitForSeconds(7f);
        text4.SetActive(true);
        text3.SetActive(false);
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("game");
    }
}

