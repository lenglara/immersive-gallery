using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceOrientationHandler : MonoBehaviour
{
    [SerializeField] private CanvasManager canvasManager;

    private bool phoneTurned = false;
    void Update()
    {
        CheckDeviceOrientation();
    }

    private void CheckDeviceOrientation()
    {
        if (phoneTurned) return;

        if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft ||
            Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            phoneTurned = true;
            canvasManager.TurnOnImageTarget();
        }
    }
}
