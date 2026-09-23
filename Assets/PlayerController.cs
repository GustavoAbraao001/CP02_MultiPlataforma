using UnityEngine;

public class ControleDeMagia : MonoBehaviour
{
    [Tooltip("Arraste o componente Animator do seu modelo aqui")]
    public Animator anim;

    [Tooltip("Arraste o Particle System da magia aqui")]
    public ParticleSystem magiaParticles;

    public void ConjurarMagia()
    {
        anim.SetTrigger("Atacar");

        
        magiaParticles.Play();
    }
}