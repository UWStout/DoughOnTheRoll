using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMenu : MonoBehaviour
{
    public MenuManager menuManager;
    public void switchMenuTo(int index)
    {
        menuManager.switchMenu(index);
    }
}
