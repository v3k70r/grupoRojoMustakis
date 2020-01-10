using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualizarValoresGameover : MonoBehaviour
{
    public TextMesh total;
    public Puntuacion puntuacion;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnEnable()
    {
        total.text = puntuacion.ToString();
       
    }
}
