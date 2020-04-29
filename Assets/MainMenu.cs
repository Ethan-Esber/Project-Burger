﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene(2);
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene(4);
    }

    public void QuitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}