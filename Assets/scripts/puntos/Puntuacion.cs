using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public static int score = 0;
    public string scoreString = "puntos:";
    public Text TextScore;
    public static Puntuacion Gamecontroller;

    void Awake()
    {
        Gamecontroller = this;   
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (TextScore != null)
        {
            TextScore.text = scoreString + score.ToString();
        }
    }
}
