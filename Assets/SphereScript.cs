using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{

    //var OOL = OutOfLevelCollider.GetComponent<Collider>();
    //var EOL = EndOfLevelCollider.GetComponent<Collider>();

    public Transform StartPosition;
   

    // Start is called before the first frame update
    void Start()
    {
        //Guardar la posicion inicial de la esfera.
        //StartPosition = transform;
        ChangeColour();

    }

    // Update is called once per frame
    void Update()
    {
       
       


    }

    public void ChangeColour()
    {
        //Obtenemos el componenete Renderer del cubo
        var sphereRenderer = this.GetComponent<Renderer>();
        // Generamos valores aleatorios para el color.        
        float r = Random.value;
        float g = Random.value;
        float b = Random.value;
        //Creamos una variable de color que ira cambiando
        Color newColor = new Color(r, g, b, 1.0f);
        //Cambiamos el color del cubo
        sphereRenderer.material.SetColor("_Color", newColor);
    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "OutOfLevelCollider")
        {
            Debug.Log("Out of Bounds Detected");
            this.transform.position = StartPosition.position;
            ChangeColour();

            //Destroy(collider.gameObject);
        }

    }
}
