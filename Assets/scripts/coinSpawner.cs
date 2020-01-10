using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawner : MonoBehaviour
{
    public GameObject[] obj;
    public float tiempoMin = 1f;
    public float tiempoMax = 2f;
    float timer;
    public GameObject coinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Generar();
    }
    void Generar()
    {
        Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 6f)
        {
            float y = Random.Range(-30f, 30f);
            Vector3 position = new Vector3(0, y, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(coinPrefab, position, rotation);
            
        }
    }
}
