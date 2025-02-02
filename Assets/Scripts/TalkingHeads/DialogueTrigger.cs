using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private bool isTracking = false;
    
    private void Start()
    {
        // Referenz auf das ImageTarget-GameObject holen
        var observerEventHandler = GetComponentInParent<DefaultObserverEventHandler>();
        if (observerEventHandler)
        {
            // Event abonnieren: Aufruf, wenn das Target gefunden wird
            observerEventHandler.OnTargetFound.AddListener(OnTrackingFound);
        }
    }

    public void OnTrackingFound()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        if (FindObjectOfType<DialogueManager>()) { Debug.Log("dialogue manager found");}
        
    }
}
