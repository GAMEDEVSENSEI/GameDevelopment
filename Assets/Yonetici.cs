using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Yonetici : MonoBehaviour
{
    
    public int CanBari = 3;
    public int Score = 0;

    public GameObject Gameover;
    public GameObject Win;

    public TextMeshProUGUI TextUI;
    public TextMeshProUGUI TextUIWin;
    ScoreYansitma scoreYansitma;
    
    
    


    void Start()
    {
        GameObject scoreYansitmaobj = GameObject.FindGameObjectWithTag("scoreYansitma");
        scoreYansitma = scoreYansitmaobj.GetComponent<ScoreYansitma>();


        Time.timeScale = 1;
    }
    void Update(){
        if(CanBari==0){
            Gameover.SetActive(true);
            Time.timeScale = 0;
            TextUI.text = Score.ToString();

        }

        if(Score==10){
            Time.timeScale = 0;
            Win.SetActive(true);
            TextUIWin.text = Score.ToString();
            scoreYansitma.ilkBolumTamamlandimi = true;
        }
    }
    


    public void GameOverBTN(){
        SceneManager.LoadScene("Menu");
        

    }
    public void WinBTN(){
        SceneManager.LoadScene("Menu");
        

    }

    



    
}
