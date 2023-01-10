using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class mov : MonoBehaviour
{
    private GameObject box;
    
    int speed = 50;



    // Start is called before the first frame update
    void Start()
    {

        box = GameObject.Find("Cube");

    }

    // Update is called once per frame
    void Update()
    {
        moves();

        


    }

    public void moves()
    {
        //Debug.Log("hola");
        Vector3 tempVect = box.transform.transform.forward + new Vector3(0, 0, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            //GetComponent<Rigidbody>().AddForce(tempVect, ForceMode.VelocityChange);
            GetComponent<Rigidbody>().velocity = tempVect * 150;

        }
        else if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;

        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            //GetComponent<Rigidbody>().AddForce(-tempVect, ForceMode.VelocityChange);
            GetComponent<Rigidbody>().velocity = -(tempVect * 150);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(Vector3.up, -1);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(Vector3.up, 1);
        }
    }
}
