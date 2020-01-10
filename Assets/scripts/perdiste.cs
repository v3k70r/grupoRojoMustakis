using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perdiste : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject GameOver2;
    public Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        GameOver.SetActive(false);
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            GameOver.SetActive(true);
            Time.timeScale = (true) ? 0 : 1f;
            Debug.Log("Se Callo :c");
        }
        if (col.gameObject.tag == "player2")
        {
            GameOver2.SetActive(true);
            Time.timeScale = (true) ? 0 : 1f;
            Debug.Log("Se Callo :c");
        }

    }
    
    

        
    
}
