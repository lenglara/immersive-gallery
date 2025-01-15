using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Vuforia;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public VuforiaBehaviour vuforiaBehaviour;
    public CanvasSwitcher firstScreen;

    public void Start()
    {
        vuforiaBehaviour.enabled = false;
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
        /*Quaternion initialRotation = Input.gyro.attitude; // Startrotation speichern*/

        while (true)
        {
            /*Quaternion currentRotation = Input.gyro.attitude;

            // Berechne den Winkel zwischen der aktuellen und der initialen Rotation
            float angle = Quaternion.Angle(initialRotation, currentRotation);*/
            /*if (angle >= 90f)
{*/
            if (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight)
            {
                videoPlayer.Stop();
                firstScreen.DeActivateAll();
                vuforiaBehaviour.enabled = true;
                yield break; // Schleife beenden
            }

            yield return null; // Warte auf den nächsten Frame
        }
    }
}
