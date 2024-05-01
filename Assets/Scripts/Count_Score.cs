using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Count_Score : MonoBehaviour
{
    public Text Scoreboard;
    public GameObject ball;
    private int Bat_1_Score = 0;
    private int Bat_2_Score = 0;
    [SerializeField] public int ScoreWin;
    public static bool canAddScore = true;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ball.transform.position.x >= 14f && canAddScore){
            canAddScore = false;
            Bat_1_Score++;
        }
         if(ball.transform.position.x <= -14f && canAddScore){
            canAddScore = false;
            Bat_2_Score++;
        }
         if(Bat_1_Score >= ScoreWin ){
            Bat_1_Score = 0;
            SceneManager.LoadScene("Player1_Win");
        }
        if(Bat_2_Score >= ScoreWin){
            Bat_2_Score = 0;
            SceneManager.LoadScene("Player2_Win");
        }
        Scoreboard.text = Bat_1_Score.ToString() + " - "+ Bat_2_Score.ToString();
    }
}
