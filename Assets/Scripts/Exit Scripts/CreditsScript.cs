﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{
    void Start()
    {
        Invoke("Exit", 18f);
    }

    void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
