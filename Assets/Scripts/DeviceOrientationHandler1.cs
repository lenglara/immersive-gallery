using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DeviceOrientationHandler1 : MonoBehaviour
{
    [SerializeField] private CanvasSwitcher canvasSwitcher;
    public VuforiaBehaviour vuforiaBehaviour;

    private bool phoneTurned = false;
    
    
    public void Start()
    {
        vuforiaBehaviour.enabled = false;
    }
    
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
            canvasSwitcher.DeActivateAll();
            vuforiaBehaviour.enabled = true;
        }
    }
}
