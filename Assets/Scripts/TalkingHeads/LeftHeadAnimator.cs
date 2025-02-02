using UnityEngine;

public class LeftHeadAnimator : MonoBehaviour
{
    [SerializeField] private Animator leftHeadAnimator;

    private bool _talkingLeft;
    
    private int _currentState;
    private static readonly int IdleL = Animator.StringToHash("IdleAnimation");
    private static readonly int TalkingL = Animator.StringToHash("LeftHeadAnimation");
    
    void Start()
    {
        _talkingLeft = false;
    }

    // Toggle zwischen Sprechend und Idle
    public void ToggleTalking(bool talking)
    {
        _talkingLeft = talking;
        UpdateAnimation();
    }
    
    private void UpdateAnimation()
    {
        if (_talkingLeft)
        {
            leftHeadAnimator.CrossFade(TalkingL, 0.1f);
        }
        else
        {
            leftHeadAnimator.CrossFade(IdleL, 0.1f);
        }
    }
}

