using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovTeclado : MonoBehaviour
{
    public int speed = 150;
    public int score = 0;
    public Text scoreText;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Me inicio");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h =  Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        scoreText.text = "Score: " + score;
        Vector3 vector = new Vector3(h, 0.5f, v);
        
        rb.AddForce(vector*speed*Time.deltaTime);
    }
}
