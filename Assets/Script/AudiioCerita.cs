using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudiioCerita : MonoBehaviour
{
    
    public AudioSource audioSource;
    public GameObject Play, Stop;
   
    public void AudioPlay()
    {

        audioSource.Play();
        Play.SetActive(false);
        Stop.SetActive(true);
    }
    public void AudioStop()
    {

        audioSource.Stop();
        Play.SetActive(true);
        Stop.SetActive(false);
    }
}
