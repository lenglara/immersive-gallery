using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.Serialization;

public class AnimationController : MonoBehaviour
{
    [FormerlySerializedAs("animator")] public Animator rightHeadAnimator;

    void Start()
    {
        // Stelle sicher, dass der Animator korrekt verknüpft ist
        if (rightHeadAnimator == null)
        {
            rightHeadAnimator = GetComponent<Animator>();
        }
    }

    void Update()
    {
        // Beispiel: Animation starten, wenn die Leertaste gedrückt wird
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rightHeadAnimator.SetBool("Talking", true);
        }

        // Beispiel: Animation stoppen, wenn die Taste "S" gedrückt wird
        if (Input.GetKeyDown(KeyCode.S))
        {
            rightHeadAnimator.SetBool("Talking", false);
        }
    }
}

