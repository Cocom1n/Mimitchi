using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ReproducirSonidos : MonoBehaviour
{
    public void ReproducirSonido(AudioSource audio)
    {
        audio.Play();
    }
}
