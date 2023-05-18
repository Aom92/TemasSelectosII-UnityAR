using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    public GameObject[] Levels;
        
    // Start is called before the first frame update
    void Start()
    {
        //Descativamos todos los niveles
        foreach (var level in Levels)
        {
            level.gameObject.SetActive(false);
        }
        //Activamos el nivel 0. 
        Levels[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLevel(int levelID)
    {
        Levels[levelID].SetActive(true);
    }
    
}
