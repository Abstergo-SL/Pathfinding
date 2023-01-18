using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eliminar : MonoBehaviour
{
    int delay = 3;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(this);
        if (this.gameObject.name == "Bullet(Clone)")
        {
            Destroy(this.gameObject,7);
        } else if (this.gameObject.name == "Ramp(Clone)")
        {
            Destroy(this.gameObject,2);
        } else if (this.gameObject.name == "dead_body")
        {
            Destroy(this.gameObject,10);
        }
        //Destroy(this.gameObject, 5);
    }

    public void elim()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
