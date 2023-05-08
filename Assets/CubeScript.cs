using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// q? Generate random numbers in C#
// https://stackoverflow.com/questions/2706500/generate-random-numbers-in-c-sharp


public class CubeScript : MonoBehaviour
{

    bool wasTouched = false;


    // Start is called before the first frame update
    void Start()
    {
     
    }





    // Update is called once per frame
    void Update()
    {
        var pivote = transform.position;
        float degreesPerSecond = 65.0f;

        if (Input.GetMouseButtonDown(0))
            Touch();

        if (wasTouched)
        {
            transform.RotateAround(pivote, Vector3.up, degreesPerSecond * Time.deltaTime);

        }

    }
    

    void Touch()
    {
        wasTouched = !wasTouched;
    }

    public void ChangeColour()
    {
        //Obtenemos el componenete Renderer del cubo
        var cubeRenderer = this.GetComponent<Renderer>(); 


        // Generamos valores aleatorios para el color.
        
        float r = Random.value;
        float g = Random.value;
        float b = Random.value;

        //Creamos una variable de color que ira cambiando
        Color newColor = new Color(r, g, b, 1.0f);
        
        //Cambiamos el color del cubo
        cubeRenderer.material.SetColor("_Color", newColor);
        
    }

}
