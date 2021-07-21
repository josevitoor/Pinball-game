using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    float power;
    public float minPower=0f;
    public float maxPower=100f;
    List<Rigidbody> ballList;
    
    void Start()
    {
        ballList = new List<Rigidbody>();
    }

    void Update()
    {
        if(ballList.Count>0)
        {
                if(power<=maxPower)
                {
                    power+=50*Time.deltaTime;
                }

                foreach(Rigidbody r in ballList)
                {
                    r.AddForce(power*Vector3.forward);
                }
        }
        else
        {
            power=0f;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            ballList.Add(other.gameObject.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
            power=0f;
        }
    }

}
