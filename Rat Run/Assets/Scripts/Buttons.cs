using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject credits;
    public void Exit()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu"); 
    }

    public void LoadCredits()
    {
        credits.SetActive(true);
    }
    public void CreditsBack()
    {
        credits.SetActive(false);
    }

    public void LoadIntroLevel()
    {
        SceneManager.LoadScene("IntroductionLevel");
    }

    public void LoadLvl1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLvl2()
    {
        SceneManager.LoadScene("Level2");
    }

}
