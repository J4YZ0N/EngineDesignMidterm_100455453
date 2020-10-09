//Description: Switches scenes based on UI button presses
//Programmer: Jayson MacFarlane
//Student ID: 100455453
//Date: October 7, 2020
//Verion 1.1

using JetBrains.Annotations;
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

    public void Quit()
    {
        Application.Quit();
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
