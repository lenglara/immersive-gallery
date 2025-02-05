using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] Animator carAnimator;
    [SerializeField] Animator wallAnimator;
    [SerializeField] WallSwitch wallSwitch;
    [SerializeField] GameObject car;
    [SerializeField] ParticleSystem[] particles;
    
    void Start()
    {
        car.SetActive(false);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayFirstAnimation();
        }
    }

    public void PlayFirstAnimation()
    {
        wallAnimator.SetTrigger("Rise Walls");
        foreach (ParticleSystem particle in particles)
        {
            particle.Play();
        }
        
    }
    
    public void StopParticles()
    {
        foreach (ParticleSystem particle in particles)
        {
            particle.Stop();
        }
        TransitionToSecondAnimation();
    }

    public void TransitionToSecondAnimation()
    {
        wallSwitch.SwitchWall();
        car.SetActive(true);
        WaitForSeconds wait = new WaitForSeconds(2f);
        PlaySecondAnimation();
    }

    public void PlaySecondAnimation()
    {
        carAnimator.SetTrigger("StartAnimation");
    }
}
