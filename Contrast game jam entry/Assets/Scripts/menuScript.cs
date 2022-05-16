using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void playGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void levelTwo()
    {
        SceneManager.LoadScene("Level2");
    }
    public void levelThree()
    {
        SceneManager.LoadScene("Level3");
    }

    public void instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void levelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
