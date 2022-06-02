using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    [SerializeField]
    private Vector3 offset;

    [Range(0, 10)]
    public float suavidade = 0.2f;
    public Transform jogador;
    void FixedUpdate(){
        transform.position = Vector3.Slerp(transform.position, jogador.position + offset, suavidade);
        transform.LookAt(jogador);
    }   
}
