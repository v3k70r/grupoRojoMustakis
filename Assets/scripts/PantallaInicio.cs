using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaInicio : MonoBehaviour
{
    bool comenzar;
    bool space;
    public GameObject CamaraInicio;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        comenzar = false;
        space = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(comenzar == false)//si no has apretado space
        {

            CamaraInicio.SetActive(true);

        }

        if (Input.GetKeyDown(KeyCode.Space) && space == false)
        {
            space = true;
        }

        if (space == true && comenzar == false)//si apretas space
        {
            CamaraInicio.SetActive(false);
            transform.Translate(velocidad, 0, 0);
        }
    }
}

