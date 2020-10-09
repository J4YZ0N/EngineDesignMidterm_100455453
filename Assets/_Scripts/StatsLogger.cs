//Description: Logs checkpoint times to .DLL file
//Programmer: Jayson MacFarlane
//Student ID: 100455453
//Date: October 8, 2020
//Verion 1.2

using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class StatsLogger : MonoBehaviour
{
    const string DLL_NAME = "MidtermCode";

    [DllImport(DLL_NAME)]
    private static extern void ResetLogger();

    [DllImport(DLL_NAME)]
    private static extern void SaveCheckpointTime(float RTBC);

    float timer = 0.0f;
    float lastTime = 0.0f;

    private void OnLevelWasLoaded(int level)
    {
        if (level == 1)
        {
            timer = 0.0f;
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;
    }

    void OnTriggerEnter(Collider checkpoint)
    {
        if (checkpoint.CompareTag("Checkpoint") || checkpoint.CompareTag("End"))
        {
            float currentTime = timer;
            float checkpointTime = currentTime - lastTime;
            lastTime = currentTime;

            SaveCheckpointTime(checkpointTime);
        }
    }

    void OnApplicationQuit()
    {
            ResetLogger();
    }
}
