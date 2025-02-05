using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class StartAnimationOnTargetFound : MonoBehaviour
{
    [SerializeField] private GameObject scanCanvas;
    /*
    public Animator animator;
    public string animationName;
    */
    public AnimationManager animationManager;
    
    private DefaultObserverEventHandler observerEventHandler;
    
    private void Start()
    {
        // Referenz auf das ImageTarget-GameObject holen
        observerEventHandler = GetComponentInParent<DefaultObserverEventHandler>();
        if (observerEventHandler != null)
        {
            // Event abonnieren: Aufruf, wenn das Target gefunden wird
            observerEventHandler.OnTargetFound.AddListener(OnTargetFound);
        }
    }

    private void OnTargetFound()
    {
        scanCanvas.SetActive(false);
        FindObjectOfType<AnimationManager>().PlayFirstAnimation();
        if(FindObjectOfType<AnimationManager>()) Debug.Log("Found animation manager");
        
    }
}
