using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public ARSceneSwitch ARSceneSwitch;


    public void Start()
    {
        
    }

    public void PlayVideo()
    {
        Debug.Log("PlayVideo");
        videoPlayer.Play();
        Debug.Log("PlayVideo Success");

        StartCoroutine(CheckForRotation());
    }

    private IEnumerator CheckForRotation()
    {
        Quaternion initialRotation = Input.gyro.attitude; // Startrotation speichern

        while (true)
        {
            Debug.Log("video still rotating");
            /*Quaternion currentRotation = Input.gyro.attitude;

            // Berechne den Winkel zwischen der aktuellen und der initialen Rotation
            float angle = Quaternion.Angle(initialRotation, currentRotation);*/
            /*if (angle >= 90f)
{*/
            /*if (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight)
            {
                videoPlayer.Stop();
                ARSceneSwitch.SwitchToARScene();
                yield break; // Schleife beenden
            }*/

            yield return null; // Warte auf den nächsten Frame
        }
    }
}
