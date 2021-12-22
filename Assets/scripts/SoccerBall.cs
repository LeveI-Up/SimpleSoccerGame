 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{
    public GameControl controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal1")
        {
            controller.IncScore1();
        }
        else if (other.gameObject.tag == "Goal2")
        {
            controller.IncScore2();
        }
    }
    
}
