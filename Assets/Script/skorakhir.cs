using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skorakhir : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Skorakhir;
    void Start()
    {
        Skorakhir.text = "" + PlayerPrefs.GetInt("skorakhir");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
