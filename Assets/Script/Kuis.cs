﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kuis : MonoBehaviour
{
    public GameObject feed_benar, feed_salah;
    void Start()
    {

    }
    public void jawaban(bool jawab)
    {

        if (jawab)
        {
            feed_benar.SetActive(false);
            feed_benar.SetActive(true);
            int skor = PlayerPrefs.GetInt("skor") + 5;
            PlayerPrefs.SetInt("skor", skor);
            PlayerPrefs.SetInt("skorakhir", skor);
        }
        else
        {
            feed_salah.SetActive(false);
            feed_salah.SetActive(true);
        }
        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
