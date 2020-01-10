using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float salto;
    public float velocidad;
    public Animator anim;
    public Rigidbody2D rb2d;
    public LayerMask MascaraSuelo;
    private bool enSuelo = true;
    public Transform comprobadorSuelo;
    private float comprobadorRadio = 0.07f;
    private bool dobleSalto = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, MascaraSuelo);
        if (enSuelo)
        {
            dobleSalto = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (GetComponent<SpriteRenderer>().flipX == true)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }

            GetComponent<Animator>().SetBool("run", true);
            transform.Translate(velocidad, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (GetComponent<SpriteRenderer>().flipX == false)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }

            transform.Translate(-velocidad, 0, 0);
            GetComponent<Animator>().SetBool("run", true);
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            GetComponent<Animator>().SetBool("run", false);

        }

        if ((enSuelo || !dobleSalto) && Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, salto));
            if (!dobleSalto && !enSuelo)
            {
                // rb2d.velocity = new Vector2(rb2d.velocity.x, salto);
                //rb2d.AddForce(new Vector2(0, salto));
                dobleSalto = true;
            }
        }



    }
}


