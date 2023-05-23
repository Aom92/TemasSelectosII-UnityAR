using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    public GameObject[] Levels;
    public Animator OverlayAnimations;
    public Animator restartbuttonAnim;
    
    public int score = 0;
    private int fails = 0;
    



    public TMP_Text scoreText;
    public TMP_Text endScore;
    public TMP_Text endRetryCount;
    public TMP_Text endTime;


    public float timeElapsed = 0;
    public bool timerRunning = false;

    private int highScore = 0;
    private float LevelOverTimer = 0;
    

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
       
        score = 0;
        highScore = 0;

        //Comenzamos el cronometro:
        timerRunning = true;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (timerRunning)
        {
            timeElapsed += Time.deltaTime;
        }

        //Conversión de unidades.
        float minutes = Mathf.FloorToInt(timeElapsed / 60);
        float seconds = Mathf.FloorToInt(timeElapsed % 60);
        float milis = (timeElapsed % 1) * 1000;

        LevelOverTimer = seconds;

        if ( LevelOverTimer >= 45)
        {
            Debug.Log("Game Over!");
            Levels[getActiveLevel()].SetActive(false);
            timerRunning = false;
            GameOver();
        }

        milis = Mathf.Round(milis);



        //Debug.Log("Score: " + score);
        endTime.text = "Time: " + minutes + ":" + seconds + "." + milis;
        scoreText.text = "Score: " + score + "\nTiempo: " + minutes + ":" + seconds + "." + milis;
    }

    public void AddScore(int points)
    {
        score += points;
        if (score > highScore)
        {
            highScore = score;
        }
    }

    public void AddFail()
    {
        fails++;
    }

    public void ResetScore()
    {
        score = 0;

    }

    public void ResetLevelTimer()
    {
        LevelOverTimer = 0;
    }

    private int getActiveLevel()
    {
        int index = 0;
        foreach (var lvl in Levels)
        {   
            if (lvl.gameObject.activeSelf)
            {
                Debug.Log("Active Level: " + index);
                return index;
            }
            index++;

        }
        return -1;  
    }

    public void GameOver()
    {

        OverlayAnimations.Play("FadeOut");

        endRetryCount.text = "Fails: " + fails;
        endScore.text = "Score: " + score;
        
        
        restartbuttonAnim.Play("ButtonSlide");
    }

    public void Victory()
    {
        timerRunning = false;
        OverlayAnimations.Play("Victory");
        restartbuttonAnim.Play("ButtonSlide");

    }

    public void RestartGame()
    {
        //Mandamos a reiniciar la escena para reiniciar el nivel.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
