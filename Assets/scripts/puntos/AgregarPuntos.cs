using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgregarPuntos : MonoBehaviour
{
    public int Puntaje = 20;

    void OnDestroy()
    {
        Puntuacion.score += Puntaje;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
