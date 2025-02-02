using UnityEngine;

public class RightHeadAnimator : MonoBehaviour
{
    [SerializeField] public Animator rightHeadAnimator;

    private bool _talkingRight;
    
    private int _currentState;
    private static readonly int IdleR = Animator.StringToHash("IdleAnimation");
    private static readonly int TalkingR = Animator.StringToHash("RightHeadAnimation");
    
    void Start()
    {
        _talkingRight = false;
    }

    // Toggle zwischen Sprechend und Idle
    public void ToggleTalking()
    {
        _talkingRight = !_talkingRight;
        Debug.Log("Talking state changed: " + _talkingRight);
        UpdateAnimation();
    }
    
    private void UpdateAnimation()
    {
        if (_talkingRight)
        {
            rightHeadAnimator.CrossFade(TalkingR, 0.1f);
        }
        else
        {
            rightHeadAnimator.CrossFade(IdleR, 0.1f);
        }
    }
}

