using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finish : MonoBehaviour
{
    public GameObject goal, gamer;
    public Text finishtxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gamer.transform.position.z <= -120.6032)
        {
            finishtxt.text = "成功";
        }
    }
}
