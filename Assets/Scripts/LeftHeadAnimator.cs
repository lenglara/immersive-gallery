using UnityEngine;

public class LeftHeadAnimator : MonoBehaviour
{
    [SerializeField] public Animator leftHeadAnimator;

    private bool _talkingLeft;
    
    private int _currentState;
    private static readonly int IdleL = Animator.StringToHash("IdleAnimation");
    private static readonly int TalkingL = Animator.StringToHash("LeftHeadAnimation");
    
    void Start()
    {
        _talkingLeft = false;
    }

    // Toggle zwischen Sprechend und Idle
    public void ToggleTalking()
    {
        _talkingLeft = !_talkingLeft;
        Debug.Log("Talking state changed: " + _talkingLeft);
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

