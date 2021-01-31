using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guzik_A : MonoBehaviour
{

    public Animation buttonPress;
    float nextSoundTime = 0;
    public AudioSource singleSFX;


    void OnMouseDown()
    {
        if (Time.time >= nextSoundTime)
        {
            buttonPress.Play();
            guzikMain.sekwencja += "A";
            singleSFX.Play();
            nextSoundTime = Time.time + 1f;

        }


    }
   
}
