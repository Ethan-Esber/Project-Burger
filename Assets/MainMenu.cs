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
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        //if (Application.isEditor)
        //{
            
        //}
        //else
        //{
            
        //}
    }

    public void LoadGame()
    {
        if (SaveGameData.LoadData("/save.dat") != null)
        {
            PauseMenu pauseMenu = GameObject.FindObjectOfType<PauseMenu>();
            pauseMenu.LoadGame("/save.dat");
        }
        else
        {
            Debug.Log("No save file found");
        }
    }
}
