using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject Picture;
    public void TogglePicture()
    {
        if (Picture.activeSelf) {
            Picture.SetActive(false);
        }
        else
        {
            Picture.SetActive(true);
        }
    }
}
