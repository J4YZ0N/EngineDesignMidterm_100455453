﻿using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(int scene)
    {
        Application.LoadLevel(scene);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Application.loadedLevelName == "Play Scene")
            {
                Application.LoadLevel(0);
            }
            else
            { 
                Application.Quit(); 
            }
        }
    }
}
