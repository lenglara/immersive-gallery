using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject turnPhoneCanvas; 
    public GameObject imageTarget;
    
    void Start()
    {
        imageTarget.GameObject().SetActive(false);
        turnPhoneCanvas.GameObject().SetActive(true);
    }
    
    public void TurnOnImageTarget()
    {
        Debug.Log("Button clicked");
        turnPhoneCanvas.GameObject().SetActive(false);
        imageTarget.GameObject().SetActive(true);
    }
}
