using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guzikMain : MonoBehaviour
{

    public static string sekwencja;
    private bool isLaunched;
    public AudioSource silnikSFX;
    public AudioSource brokenSFX;
    public Animation buttonPress;
    float nextSoundTime = 0;
    public AudioSource tromboneSFX;


    void OnMouseDown()
    {


        if (Time.time >= nextSoundTime)
        {
            Debug.Log(sekwencja);
            buttonPress.Play();

            if (sekwencja == "ABCDE" & isLaunched == false)
            {
                silnikSFX.Play();
                tromboneSFX.Play();
                sekwencja = "";
                Debug.Log("Uda�o si�!");
                isLaunched = true;

            }
            else
            {
                brokenSFX.Play();
                sekwencja = "";
                Debug.Log("Nie uda�o si� !");
            }
            
            
            nextSoundTime = Time.time + 2f;

        }


    }




}
