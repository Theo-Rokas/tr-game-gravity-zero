using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public static SoundScript instance;
    
    public AudioSource clickSound, jumpSound, obtainSound, dieSound, spaceshipSound;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public float ClickSound()
    {        
        clickSound.Play();
        float length = clickSound.clip.length;
        return length;
    }

    public void JumpSound()
    {
        jumpSound.Play();
    }

    public void ObtainSound()
    {
        obtainSound.Play();
    }

    public void DieSound()
    {
        dieSound.Play();
    }

    public void SpaceshipSound()
    {
        spaceshipSound.Play();
    }
}
