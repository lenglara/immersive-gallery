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
    public AudioSource audioSource;  
    public AudioClip introClip;
    public AudioSource wallRumble;
    public AudioSource carAudioSource;
    public float waitTimeReduce;
    
    void Start()
    {
        car.SetActive(false);
    }
    
    public void PlayFirstAnimation()
    {
        
        StartCoroutine(PlayFirstAnimationCoroutine());
    }
    
    private IEnumerator PlayIntroTextCoroutine()
    {
        audioSource.clip = introClip;
        audioSource.Play();
        yield return new WaitForSeconds(2f);
        StopParticles();
        yield return new WaitForSeconds(introClip.length - 3);

        // Dann startet die erste Animation mit einer Verzögerung von 2 Sekunden
        StartCoroutine(StopParticlesCoroutine());
    }

    private IEnumerator PlayFirstAnimationCoroutine()
    {
        wallRumble.Play();
        // Partikel abspielen
        foreach (ParticleSystem particle in particles)
        {
            particle.Play();
        }

        wallAnimator.SetTrigger("Rise Walls");
        yield return new WaitForSeconds(wallRumble.clip.length);

        StartCoroutine(PlayIntroTextCoroutine());
    }

    public void StopParticles()
    {
        foreach (ParticleSystem particle in particles)
        {
            particle.Stop();
        }
    }

    private IEnumerator StopParticlesCoroutine()
    {
        // 2 Sekunden warten
        yield return new WaitForSeconds(1f);
        // Zur nächsten Animation übergehen
        TransitionToSecondAnimation();
    }

    public void TransitionToSecondAnimation()
    {
        StartCoroutine(TransitionToSecondAnimationCoroutine());
    }

    private IEnumerator TransitionToSecondAnimationCoroutine()
    {
        // Wand wechseln und Auto aktivieren
        wallSwitch.SwitchWall();
        car.SetActive(true);

        // 2 Sekunden warten
        yield return new WaitForSeconds(1f);

        // Nächste Animation starten
        PlaySecondAnimation();
    }

    public void PlaySecondAnimation()
    {
        carAudioSource.Play();
        carAnimator.SetTrigger("StartAnimation");
    }
}
