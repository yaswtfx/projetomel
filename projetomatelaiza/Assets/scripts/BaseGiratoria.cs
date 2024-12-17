using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGiratoria : MonoBehaviour
{
    public float rotationSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Obter entrada do teclado
        float rotationInput = Input.GetAxis("Horizontal"); // Usa setas ou teclas A/D

        // Rotacionar a plataforma ao redor do eixo Y
        transform.Rotate(Vector3.up * rotationInput * rotationSpeed * Time.deltaTime);
    }
}
