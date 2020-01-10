using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguirPersonaje : MonoBehaviour
{
    public Transform personaje;
    public float separacion = 3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(personaje.position.x + separacion, transform.position.y, transform.position.z);

    }
}

