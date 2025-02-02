using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.Serialization;

public class AnimationController : MonoBehaviour
{
    [SerializeField] public Animator rightHeadAnimator;
    // [SerializeField] public Animator leftHeadAnimator;

    //private bool _talkingLeft;
    private bool _talkingRight;
    
    private int _currentState;
    private static readonly int IdleR = Animator.StringToHash("IdleAnimation");
    private static readonly int TalkingR = Animator.StringToHash("RightHeadAnimation");
    // private static readonly int TalkingL = Animator.StringToHash("LeftHeadAnimation");
    
    void Start()
    {
        // Stelle sicher, dass der Animator korrekt verknüpft ist
        if (rightHeadAnimator == null)
        {
            Debug.Log("rightHeadAnimator is null");
        }

        _talkingRight = false;
    }

    void Update()
    {
        // Beispiel: Animation starten, wenn die Leertaste gedrückt wird
        if (Input.GetKeyDown(KeyCode.S))
        {
            //rightHeadAnimator.SetBool("Talking", true);

            _talkingRight = false;
        }

        // Beispiel: Animation stoppen, wenn die Taste "S" gedrückt wird
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // rightHeadAnimator.SetBool("Talking", false);

            _talkingRight = true;
        }
        
        var state = GetState();
        
        if (state == _currentState) return;
        rightHeadAnimator.CrossFade(state, 0, 0);
        _currentState = state;
    }
    
    private int GetState() {
        if (_talkingRight) return TalkingR;
        return IdleR;
    }
}

