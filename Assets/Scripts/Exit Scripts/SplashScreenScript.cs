﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenScript : MonoBehaviour
{    
    void Start()
    {
        Invoke("Exit", 2f);
    }

    void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
