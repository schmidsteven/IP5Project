using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFHNW : MonoBehaviour {


    public void OpenURL()
    {
        Application.OpenURL("http://fhnw.ch");
        Debug.Log("is this working?");
    }

}

