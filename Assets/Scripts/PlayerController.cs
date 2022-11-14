using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 10f;
    public float horizontalInput;
    
    void Update()
    {
        // Detectar el Input Horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Movimiento hacia adelante
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
        // Movimiento lateral manual
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
    }
}
