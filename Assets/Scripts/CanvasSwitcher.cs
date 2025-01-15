using System;
using UnityEngine;

public class CanvasSwitcher : MonoBehaviour
{
    public GameObject startScreen; 
    public GameObject menuScreen;
    public GameObject videoScreen;
    public void Start()
    {
        DeActivateAll();
        startScreen.SetActive(true);
    }

    public void DeActivateAll()
    {
        startScreen.SetActive(false);
        menuScreen.SetActive(false);
        videoScreen.SetActive(false);
    }

    public void SwitchToMenuScreen() 
    {
        DeActivateAll();
        menuScreen.SetActive(true);
    }

    public void SwitchToVideoScreen() 
    {
        DeActivateAll();
        videoScreen.SetActive(true);
    }
}
