using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class disparo : MonoBehaviour
{
    //public NavMeshAgent bullet;

    Rigidbody bullet;
    Vector3 mcposition, force;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.gameObject);
        mcposition = GameObject.Find("Cube").transform.position;
        this.gameObject.transform.LookAt(mcposition);
        this.gameObject.GetComponent<Rigidbody>().AddForce(this.gameObject.transform.forward * 1000F);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit: " + collision.gameObject.name);
        if (collision.gameObject.name != "Turret" && collision.gameObject.name != "Bullet(Clone)")
        {

            //this.gameObject.AddComponent<eliminar>();
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
