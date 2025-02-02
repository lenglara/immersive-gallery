using UnityEngine;

public class RightHeadAnimator : MonoBehaviour
{
    [SerializeField] private Animator rightHeadAnimator;

    private bool _talkingRight;
    
    private int _currentState;
    private static readonly int IdleR = Animator.StringToHash("IdleAnimation");
    private static readonly int TalkingR = Animator.StringToHash("RightHeadAnimation");
    
    void Start()
    {
        _talkingRight = false;
    }

    // Toggle zwischen Sprechend und Idle
    public void ToggleTalking(bool talking)
    {
        _talkingRight = talking;
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

