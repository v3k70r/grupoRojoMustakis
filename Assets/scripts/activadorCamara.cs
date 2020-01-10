using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activadorCamara : MonoBehaviour
{
    [Tooltip("Tiempo inicial en segundos")]
    public int tiempoInicial;

    [Tooltip("Escala de tiempo del Reloj")]
    [Range(-10.0f, 10.0f)]
    public float escalaDeTiempo = 1;

    public Text tiempotext, tiempotext2;
    private float tiempoAmostrarEnSegundos;
    private float tiempoDelFrameConTimeScale;
    public float velocidad;
    private float reinicio, escalaDeTiempoAlPausar, EscalaDeTiempoInicial;
    private bool estapausado = false;
    
    // Start is called before the first frame update
    void Start()
    {
        EscalaDeTiempoInicial = EscalaDeTiempoInicial;
        tiempotext = GetComponent<Text>();
        tiempoAmostrarEnSegundos = tiempoInicial;
        ActualizarReloj(tiempoInicial);
    }

    // Update is called once per frame
    
    void Update()
    {
        tiempoDelFrameConTimeScale = Time.deltaTime * escalaDeTiempo;
        tiempoAmostrarEnSegundos += tiempoDelFrameConTimeScale;
        ActualizarReloj(tiempoAmostrarEnSegundos);
     
    }
    public void ActualizarReloj(float tiempoEnSegundos)
    {
        int minutos = 0;
        int segundos = 0;
        string textoDelReloj;

        if (tiempoEnSegundos < 0) tiempoEnSegundos = 0;

        minutos = (int)tiempoEnSegundos / 60;
        segundos = (int)tiempoEnSegundos % 60;

        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");

        tiempotext.text = textoDelReloj;
        tiempotext2.text = textoDelReloj;
    }
     public void Pausar()
     {
         if (!estapausado)
         {
             estapausado = true;
             escalaDeTiempoAlPausar = escalaDeTiempo;
             escalaDeTiempo = 0;
         }
     }
     public void Continuar()
     {
         if (estapausado)
         {
             estapausado = false;
             escalaDeTiempo = escalaDeTiempoAlPausar;
         }
     }
    public void reiniciarReloj()
    {
        estapausado = false;
        escalaDeTiempo = EscalaDeTiempoInicial;
        tiempoAmostrarEnSegundos = tiempoInicial;
        ActualizarReloj(tiempoAmostrarEnSegundos);
    }



}
