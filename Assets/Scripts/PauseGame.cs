using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject gameScreen;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pauseScreen.SetActive(true);
            gameScreen.SetActive(false);
        }
    }
}
