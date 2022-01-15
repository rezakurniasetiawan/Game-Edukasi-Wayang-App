using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlay : MonoBehaviour
{
    public Slider VolumeSlider;
    public GameObject ObjectMusic;

    private float MusicVolume = 0f;
    public AudioSource AudioSource;


    private void Start()
    {
        ObjectMusic = GameObject.FindWithTag("GameMusic");
        AudioSource = ObjectMusic.GetComponent<AudioSource>();

        MusicVolume = PlayerPrefs.GetFloat("Volume");
        AudioSource.volume = MusicVolume;
        VolumeSlider.value = 1;
    }

    private void Update()
    {
        AudioSource.volume = MusicVolume;
        PlayerPrefs.GetFloat("Volume", MusicVolume);
    }
    public void VolumeUpdater(float Volume)
    {
        MusicVolume = Volume;
    }
}
