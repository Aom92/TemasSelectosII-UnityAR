using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{


    public GameObject prefab;
    public GameObject spawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Sphere") == null)
        {
            GameObject Sphere = Instantiate(prefab, spawnLocation.transform);
            Sphere.name = "Sphere";
            Sphere.transform.localPosition = Vector3.zero;
            Sphere.transform.localRotation = Quaternion.identity;
            
        }
    }
}
