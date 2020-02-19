using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject gameScreen;

    public void resumeGame()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        gameScreen.SetActive(true);
    }
}
