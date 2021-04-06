using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyover : MonoBehaviour
{
    public float speed;
    bool Ispressed = false;
    public GameObject button1;
    public GameObject button2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if(transform.position.z >= 30)
        {
            if (Ispressed == true)
            {
                Klik();
            }
            else if (Ispressed == false)
                Jeda();
            speed = 0;
        }

    }   
    
    public void Klik()
    {
        button2.SetActive(true);
        button1.SetActive(false);
        Ispressed = true;
        speed = 1;
    }
    
    public void Jeda()
    {
        button2.SetActive(false);
        button1.SetActive(true);
        Ispressed = false;
        speed = 0;
    }
       
}
