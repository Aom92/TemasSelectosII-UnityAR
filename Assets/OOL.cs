using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOL : MonoBehaviour
{

    Vector3 StartPosition;
    GameObject SphereReference;

    // Start is called before the first frame update
    void Start()
    {
        GameObject SphereReference = GameObject.Find("SpawnLocation");
        StartPosition = SphereReference.transform.position;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

}
