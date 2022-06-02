using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroirMagia : MonoBehaviour
{
    public float DistanciaDaMagia;
    void Start()
    {
        GameObject.Destroy(gameObject, DistanciaDaMagia);
    }

}
