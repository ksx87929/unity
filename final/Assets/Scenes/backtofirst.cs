using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backtofirst : MonoBehaviour
{
    public GameObject p, person;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(person.transform.position.y<2)
        {
            Vector3 pos= new Vector3(-0.03f, 9.74f, 198.94f);
            
            person.transform.position=pos;
        }
    }
}
