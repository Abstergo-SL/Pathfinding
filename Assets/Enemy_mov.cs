using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.AI;
using Unity.VisualScripting;
using System;
using UnityEditor.PackageManager;

public class Enemy_mov : MonoBehaviour 
{
    //private mov square;
    private GameObject square;
    public NavMeshAgent ball;
   
    int speed = 1;
    bool chiv = true;
    float acc;
    Vector3 mcposition, enemyposition;
    

    // Start is called before the first frame update
    void Start()
    {

        ball = GetComponent<NavMeshAgent>();
        ball.speed = 9.4F;
        square = GameObject.Find("cube");
        

        //StartCounter();


    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Cube")
        {
            
            Debug.Log(GetComponent<NavMeshAgent>().speed);
            mcposition = GameObject.Find("Cube").transform.position;
            ball.SetDestination(mcposition);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //mcposition = GameObject.Find("Cube").transform.position;
        //enemyposition = GameObject.Find("Sphere").transform.position;

        

        //if (Input.GetMouseButton(1))
        //{
            
        //    Debug.Log(mcposition);
            
        //    ball.SetDestination(mcposition);

        //}

        //Forward();

    }

    /* private void OnCollisionEnter(Collision collision)
    {
        Forward();
    } */

    

    

}
