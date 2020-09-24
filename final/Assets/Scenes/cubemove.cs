using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cubemove : MonoBehaviour
{
    public GameObject cube1, cube2, cube3;
    int count = 0,first=1;
    float x=0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if(count==2500&&first==1)
        {
            x = -x;
            count = 0;
            first = 0;
        }
        if(count==5000&&first==0)
        {
            x = -x;
            count = 0;
        }
        cube1.transform.Translate(x, 0, 0);
        cube2.transform.Translate(-x, 0, 0);
        cube3.transform.Translate(x, 0, 0);
        count++;
        
    }
}
