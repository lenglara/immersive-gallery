using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackableHandler : DefaultObserverEventHandler
{
    public AudioSource ContentAudio;
    
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        
        // Define custom behaviour
        ContentAudio.Play();
        
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        
        ContentAudio.Stop();
    }
}
