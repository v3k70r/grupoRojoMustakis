using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManager;
    public Text scoreText;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = this;
    }

    public void RaiseScore(int s)
    {
        score += s;
        scoreText.text = score + "";
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
