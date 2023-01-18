using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Data;

public class set_trap : MonoBehaviour
{
    private GameObject square;
    public GameObject trap;
    GameObject[] ntraps;
    Ray mouse;
    int cont;
    



    // Start is called before the first frame update
    void Start()
    {

        square = GameObject.Find("Cube");
        
        //trap = GameObject.Find("Trap");
        ntraps = new GameObject[10];
        
        cont = 0;

    }

    


    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButtonDown(1))
        if (Input.GetMouseButton(1))
        {
            
            mouse = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(mouse, out var hitInfo))
            {
                
                if (square.GetComponent<BoxCollider>().bounds.Contains(hitInfo.point))
                {

                    
                    
                    Debug.Log(cont);
                    //Debug.Log(hitInfo.point);

                    //trap.gameObject.AddComponent<eliminate>();
                    ntraps[cont] = Instantiate(trap, hitInfo.point, Quaternion.Euler(0, square.transform.eulerAngles.y+90, -10f));
                    //Destroy(ntraps[cont], 2);

                    cont++;

                    if (cont == 10)
                    {  
                        Debug.Log(ntraps.LongLength);
                        DestroyImmediate(ntraps[0], true);
                        for (int i = 0; i < 9; i++)
                        {
                            ntraps[i] = ntraps[i + 1];
                        }

                        //ntraps = new GameObject[10];
                        cont = 9;
                    }
                      
                    
                    //newtrap.transform.position = hitInfo.point;

                }

            }

        }

    }
}
