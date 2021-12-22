using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public Text scoreText1;
    public Text scoreText2;

    private int score1 = 0;
    private int score2 = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncScore1()
    {
        score1++;
        scoreText1.text = "Score: " + score1.ToString();
    }
    public void IncScore2()
    {
        score2++;
        scoreText2.text = "Score: " + score2.ToString();
    }
}
