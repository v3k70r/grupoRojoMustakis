using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour
{
    public KeyCode Disparar;
    public Transform comprobadoritems;
    private float comprobadorRadio = 0.07f;
    public LayerMask MascaraSuelo;
    private bool adisparar = true;
    private bool dispara = false;

    public GameObject[] obj;
    public float tiempoMin = 1f;
    public float tiempoMax = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void FixedUpdate()
    {
        adisparar = Physics2D.OverlapCircle(comprobadoritems.position, comprobadorRadio, MascaraSuelo);
        if (adisparar)
        {
            dispara = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(dispara == true && Input.GetKeyDown("Disparar"))
        {
            Generar();
        }
    }
    void Generar()
    {
        Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
    }
}
