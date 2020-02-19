using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuManager : MonoBehaviour
{
    public GameObject[] soundSprites = new GameObject[2];
    public GameObject[] menuScreens = new GameObject[4];

    public void switchMenu(int index)
    {
        for(int i = 0; i < menuScreens.Length; i++)
        {
            if(i != index)
            {
                menuScreens[i].SetActive(false);
            }
            else if (i == index)
            {
                menuScreens[i].SetActive(true);
            }
        }
    }
}
