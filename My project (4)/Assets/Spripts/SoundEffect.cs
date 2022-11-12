using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{

   // public GameObject gameManager;
    public AudioSource scr;
    public AudioClip flap, hit, point, die;


    public void PlayFlapSound()
    {
        scr.clip = flap;
        scr.Play();
    }
    public void PlayHitSound()
    {
        scr.clip = hit;
        scr.Play();
    }
    public void PlayPointSound()
    {
        scr.clip = point;
         scr.Play();
    }
    public void PlayDieSound()
    {
        scr.clip = die;
        scr.Play();
    }
}
