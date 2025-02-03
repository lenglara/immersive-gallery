using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Vuforia;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    [SerializeField] private GameObject scanCanvas;
    
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
        scanCanvas.GameObject().SetActive(false);
        
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        if (FindObjectOfType<DialogueManager>()) { Debug.Log("dialogue manager found");}
        
    }
}
