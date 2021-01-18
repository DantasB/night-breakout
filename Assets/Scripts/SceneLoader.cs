using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene(GetCurrentSceneIndex() + 1);
    }

    private int GetCurrentSceneIndex()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        TreatIndex(ref currentSceneIndex);

        return currentSceneIndex;
    }

    private void TreatIndex(ref int currentSceneIndex)
    {
        if (currentSceneIndex == 2)
        {
            currentSceneIndex = -1;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
