using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Stats_Logger : MonoBehaviour
{
    const string DLL_NAME = "Midterm Code";

    [StructLayout(LayoutKind.Sequential)]
    struct Clock
    {
        public int seconds;
        public int minutes;
        public int hours;
    }

    [DllImport(DLL_NAME)]
    private static extern int GetID();

    [DllImport(DLL_NAME)]
    private static extern void SetID(int id);

    [DllImport(DLL_NAME)]
    private static extern Clock GetTime();

    [DllImport(DLL_NAME)]
    private static extern void SetTime(int seconds, int minutes, int hours);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SetID(500);
            Debug.Log(GetID());

            SetTime(1, 2, 3);
            Debug.Log(GetTime().hours);
            Debug.Log(GetTime().minutes);
            Debug.Log(GetTime().seconds);
        }
    }
}
