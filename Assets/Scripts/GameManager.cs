using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public void Awake()
    {
        //check if instance already exists
        if (instance == null)
        {
            //if not, set instance to this
            instance = this;
        }
        //instance already exists and it is not this
        else if (instance != this)
        {
            //then destroy this. This enforces the singleton patter,
            //meaning there can only be one instance of the GameManager
            Destroy(gameObject);

        }

        //set this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }
}
