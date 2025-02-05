using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{

    [SerializeField] private AnimationManager animationManager;

    private void DisableParticles()
    {
        animationManager.StopParticles();
    }
}
