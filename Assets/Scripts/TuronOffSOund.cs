using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuronOffSOund : MonoBehaviour
{
    public MenuManager menuManager;
    public AudioSource audioSource;
    public void toggleSound()
    {

        audioSource = menuManager.gameManager.GetComponent<AudioSource>();
        if (menuManager.soundSprites[0].activeSelf)
        {
            audioSource.mute = true;

            menuManager.soundSprites[0].SetActive(false);
            menuManager.soundSprites[1].SetActive(true);
        }
        else
        {
            audioSource.mute = false;
            menuManager.soundSprites[1].SetActive(false);
            menuManager.soundSprites[0].SetActive(true);
        }
    }
}
