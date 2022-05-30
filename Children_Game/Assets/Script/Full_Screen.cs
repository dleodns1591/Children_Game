using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Full_Screen : MonoBehaviour
{
    void Start() => SetResolution();

    public void SetResolution()
    {
        int width = 1920;
        int height = 1080;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(width, height, true);
    }
}
