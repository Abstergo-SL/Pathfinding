using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Track_n_shoot : MonoBehaviour
{

    GameObject turret;
    public GameObject bullet;
    int cont = 0;

    // Start is called before the first frame update
    void Start()
    {
        turret = GameObject.Find("Turret");
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Cube")
        {
            cont++;
            //Debug.Log(GetComponent<NavMeshAgent>().speed);
            turret.transform.LookAt(other.gameObject.transform);
            //cont = GameObject.FindGameObjectsWithTag("Bullet").Length;
            Debug.Log(cont);
            
            if (cont%8 == 0) 
            {
                Instantiate(bullet, turret.transform.position, transform.rotation);
            }
            
            
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
