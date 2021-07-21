using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    public GameObject balls;
    void Start()
    {

    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision colisor)
    {
        if(colisor.gameObject.CompareTag("Limit"))
        {
            transform.position = new Vector3(3, 0, 0);
            balls.GetComponent<ScoreScript>().setBalls();
        }
        if(colisor.gameObject.CompareTag("Portal"))
        {
            transform.position = new Vector3(-2, 0, 5);
            balls.GetComponent<ScoreScript>().setScore(15);
        }
        if(colisor.gameObject.CompareTag("Obstacle1"))
        {
            balls.GetComponent<ScoreScript>().setScore(10);
        }
            if(colisor.gameObject.CompareTag("Obstacle2"))
        {
            balls.GetComponent<ScoreScript>().setScore(20);
        }
            if(colisor.gameObject.CompareTag("Obstacle3"))
        {
            balls.GetComponent<ScoreScript>().setScore(30);
        }
    }
}
