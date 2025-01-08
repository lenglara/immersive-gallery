using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeviceOrientationHandler : MonoBehaviour
{
    void Update()
    {
        if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft ||
            Input.deviceOrientation == DeviceOrientation.LandscapeRight)
            SceneManager.LoadScene("Scenes/AR_Vuforia");
    }
}
