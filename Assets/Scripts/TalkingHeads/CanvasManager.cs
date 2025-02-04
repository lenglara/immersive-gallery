using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject buttonCanvas;
    public GameObject turnPhoneCanvas;
    public GameObject scanCanvas;
    public GameObject imageTarget;
    
    void Start()
    {
        buttonCanvas.GameObject().SetActive(false);
        imageTarget.GameObject().SetActive(false);
        scanCanvas.GameObject().SetActive(false);
        turnPhoneCanvas.GameObject().SetActive(true);
    }
    
    public void TurnOnImageTarget()
    {
        buttonCanvas.GameObject().SetActive(true);
        scanCanvas.GameObject().SetActive(true);
        turnPhoneCanvas.GameObject().SetActive(false);
        imageTarget.GameObject().SetActive(true);
    }
}
