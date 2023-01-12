using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eliminate : MonoBehaviour
{
    int delay = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this);
        Destroy(this, 0);
    }

    public void elim()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
