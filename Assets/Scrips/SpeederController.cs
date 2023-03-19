using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpeederController : MonoBehaviour
{

    public MovTeclado objeto;
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CorutinaSpeed());
        objeto.speed = objeto.speed * 3;
    }
    
    IEnumerator CorutinaSpeed()
    {
        yield return new WaitForSeconds(3);
        objeto.speed = 150;
    }
}
