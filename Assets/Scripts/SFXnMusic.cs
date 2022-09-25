using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXnMusic : MonoBehaviour
{
    public AudioSource mainMusic;
    public AudioSource baseHit;
    public AudioSource playerHit;


    public void playBaseHit()
    {
        baseHit.Play();
    }

    public void playPlayerHit()
    {
        playerHit.Play();
    }



}

