using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneAnimationController : MonoBehaviour
{
    private Animator animator;
    private float timer = 0f;
    public float idleDuration = 3f; // Zeit, wie lange die Idle-Animation dauern soll
    public float otherAnimationDuration = 2f; // Zeit für die andere Animation

    private enum AnimationState { TurnPhone, LandscapeOrientation }
    private AnimationState currentState = AnimationState.TurnPhone;

    private void Start()
    {
        animator = GetComponent<Animator>();
        PlayIdleAnimation();
    }

    private void Update()
    {
        timer += Time.deltaTime; // Zählt die Zeit seit dem letzten Frame

        switch (currentState)
        {
            case AnimationState.TurnPhone:
                if (timer >= idleDuration)
                {
                    timer = 0f;
                    PlayOtherAnimation();
                }
                break;

            case AnimationState.LandscapeOrientation:
                if (timer >= otherAnimationDuration)
                {
                    timer = 0f;
                    PlayIdleAnimation();
                }
                break;
        }
    }

    private void PlayIdleAnimation()
    {
        animator.Play("TurnPhone"); // Der Name der Idle-Animation im Animator
        currentState = AnimationState.TurnPhone;
    }

    private void PlayOtherAnimation()
    {
        animator.Play("LandscapePositionAnimation");
        currentState = AnimationState.LandscapeOrientation;
    }
}
