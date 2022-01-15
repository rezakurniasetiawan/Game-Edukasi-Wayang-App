using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Url : MonoBehaviour
{
    public string Urls;

    public void OpenLink()
    {
        Application.OpenURL(Urls);
    }
}
