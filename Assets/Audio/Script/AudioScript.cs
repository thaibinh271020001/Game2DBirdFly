using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource Sound;
    

    public void ClickToMakeSound()
    {
        Sound.Play();
    }
}
