using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject turnPhoneCanvas;
    public GameObject scanCanvas;
    public GameObject imageTarget;
    
    void Start()
    {
        imageTarget.GameObject().SetActive(false);
        scanCanvas.GameObject().SetActive(false);
        turnPhoneCanvas.GameObject().SetActive(true);
    }
    
    public void TurnOnImageTarget()
    {
        scanCanvas.GameObject().SetActive(true);
        turnPhoneCanvas.GameObject().SetActive(false);
        imageTarget.GameObject().SetActive(true);
    }
}
