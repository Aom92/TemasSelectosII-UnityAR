using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EOL : MonoBehaviour
{

    public Transform StartPosition;
    public GameObject NextLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Sphere")
        {
            Debug.Log("End Of Level 1 Detected! ");
            this.transform.position = StartPosition.position;
            //ChangeColour();

            //Destroy(collider.gameObject);
        }

    }

    public void ChangeLevel()
    {

    }
}
