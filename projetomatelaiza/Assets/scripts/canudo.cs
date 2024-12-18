using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class canudo : MonoBehaviour
{
    public float velocidadeSubida = 5f; 
    public float velocidadeDescida = 5f; // Velocidade com que a plataforma desce
    private Vector3 posicaoInicial;
    void Start()
    {
        posicaoInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.Space))
        {
            // Move a plataforma para cima enquanto o espaço está pressionado
            transform.Translate(Vector3.up * velocidadeSubida * Time.deltaTime);
        }
        else if (!Input.GetKey(KeyCode.Space) && transform.position.y > posicaoInicial.y)
        {
            // Move a plataforma para baixo até a posição inicial quando o espaço é solto
            transform.Translate(Vector3.down * velocidadeDescida * Time.deltaTime);

            // Garante que a plataforma não passe da posição inicial
            if (transform.position.y < posicaoInicial.y)
            {
                transform.position = posicaoInicial;
            }
        }
    }
}
