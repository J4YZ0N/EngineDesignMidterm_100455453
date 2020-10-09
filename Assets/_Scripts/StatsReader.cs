//Description: Reads checkpoint times from .DLL file
//Programmer: Jayson MacFarlane
//Student ID: 100455453
//Date: October 9, 2020
//Verion 1.2

using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class StatsReader : MonoBehaviour
{
    const string DLL_NAME = "MidtermCode";

    [DllImport(DLL_NAME)]
    private static extern void ResetLogger();

    [DllImport(DLL_NAME)]
    private static extern float GetTotalTime();

    [DllImport(DLL_NAME)]
    private static extern float GetCheckpointTime(int index);

    [DllImport(DLL_NAME)]
    private static extern int GetNumCheckpoints();

    public Text stats;

    float timer = 0.0f;

    private void OnLevelWasLoaded(int level)
    {
        if (level == 1)
        {
            timer = 0.0f;
        }
    }

    public float LoadTime(int index)
    {
        if (index >= GetNumCheckpoints())
        {
            return 0.0f;
        }
        else
        {
            return GetCheckpointTime(index);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Application.loadedLevelName == "End Scene")
        {
            stats.text = "Checkpoint 1: " + LoadTime(0) + " seconds" + "\n\n"
                + "Checkpoint 2: " + LoadTime(1) + " seconds" + "\n\n"
                + "Checkpoint 3: " + LoadTime(2) + " seconds" + "\n\n"
                + "Checkpoint 4: " + LoadTime(3) + " seconds" + "\n\n"
                + "Checkpoint 5: " + LoadTime(4) + " seconds" + "\n\n"
                + "Total Time: " + GetTotalTime() + " seconds";
        }
        else
        {
            stats.text = "Total Time: " + timer.ToString("F2");
        }
    }

    void OnApplicationQuit()
    {
        ResetLogger();
    }
}
