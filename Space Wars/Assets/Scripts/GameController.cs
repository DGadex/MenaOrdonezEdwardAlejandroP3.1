using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static int score = 0;
    public string scorePrefix = "Score: ";
    public string healthPrefix = "Health:  ";
    

    public Text scoreText = null;

    public Text gameOverText = null;

 

    public static GameController gameController = null;


    void Awake()
    {
        gameController = this;
    }




    // Start is called before the first frame update
    void Start()
    {
        gameController.gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(scoreText != null)
        {
            scoreText.text = scorePrefix + score.ToString();
        }
    }
    
    public static void GameOver()
    {
        if(gameController.gameOverText != null)
        {
            gameController.gameOverText.gameObject.SetActive(true);
        }
    }

}
