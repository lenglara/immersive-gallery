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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _talkingRight = !_talkingRight;  // Toggle zwischen Sprechend und Idle
            Debug.Log("Talking state changed: " + _talkingRight);
            UpdateAnimation();
        }
    }
    
    private void UpdateAnimation()
    {
        if (_talkingRight)
        {
            // rightHeadAnimator.CrossFade(TalkingR, 0.1f);
            rightHeadAnimator.Play(TalkingR);
        }
        else
        {
            rightHeadAnimator.CrossFade(IdleR, 0.1f);
        }
    }
}

