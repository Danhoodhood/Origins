using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButtonSound : MonoBehaviour
{
    public AudioSource soundPlay;


    public void PlayThisSoundEffect()
    {
        soundPlay.Play();
    }
}
