using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOL : MonoBehaviour
{

    public Transform RespawnPosition;
    public GameObject PreviousLevel;
    public GameObject ThisLevel;
    public bool isFirstLevel = false;
    

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
            //Actualizar Puntuación. 
            this.SendMessageUpwards("AddScore", -1);

            if (!isFirstLevel)
            {
                //Movemos a la posicion de inicio del nivel anterior
                collision.gameObject.transform.position = RespawnPosition.position;
                collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

                //Activamos el anterior nivel
                PreviousLevel.SetActive(true);

                //Desactivamos el nivel actual
                ThisLevel.SetActive(false);
                
            }
            else
            {
                //Movemos a la posicion de inicio
                Debug.Log("You Fell!");

                //TODO:
                //DisplayGameOverAnimation(). 
                
                
            }

        }

    }



}
