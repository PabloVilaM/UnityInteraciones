using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaController : MonoBehaviour
{
    public MovTeclado objeto2;
    public GameObject objeto;
    private void OnTriggerEnter(Collider other)
    {
        objeto.transform.localScale = new Vector3(objeto.transform.localScale.x*2, objeto.transform.localScale.y*2, objeto.transform.localScale.z*2);
        Destroy(this.gameObject);
        objeto2.score += 1;
    }
}
