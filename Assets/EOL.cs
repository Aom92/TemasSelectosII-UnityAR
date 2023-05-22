using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EOL : MonoBehaviour
{

    public Transform StartPosition;
    public GameObject NextLevel;
    public GameObject ThisLevel;
    public ParticleSystem victoryEffect;
    public bool isLastLevel = false;

    private GameControl gameControlScript;

    // Start is called before the first frame update
    void Start()
    {
        gameControlScript = this.GetComponentInParent<GameControl>();
        victoryEffect.Stop();
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
            this.SendMessageUpwards("AddScore", 1);
           
            if (!isLastLevel)
            {
                //Movemos a la posicion de inicio
                collision.gameObject.transform.position = StartPosition.position;
                collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;


                //Activamos el siguiente nivel
                NextLevel.SetActive(true);


                //Desactivamos el nivel actual
                ThisLevel.SetActive(false);
                //Destroy(collider.gameObject);
                
            }
            else if(isLastLevel)
            {
                //Movemos a la posicion de inicio
                Debug.Log("You Win!");
                victoryEffect.Play();
                
                //End Screen Effects!
            }

        }

    }

}
