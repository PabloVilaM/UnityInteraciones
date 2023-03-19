using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinaController : MonoBehaviour
{
    public MovTeclado objeto;
    public Renderer render;
    private Material material;
    public GameObject objeto2;
    void Start()
    {
        render = objeto2.GetComponent<Renderer>();

        material = render.material;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Mina"))
        {
            Debug.Log("EntroMina");
            StartCoroutine(CorutinaSpeed());
            objeto.speed = 0;
            material.color = Color.cyan;
        }
    }
    
    IEnumerator CorutinaSpeed()
    {
        yield return new WaitForSeconds(3);
        objeto.speed = 150;
        material.color = Color.red;
    }
}
