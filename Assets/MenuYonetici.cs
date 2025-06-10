using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuYonetici : MonoBehaviour
{
    ScoreYansitma scoreYansitma2;
    public GameObject BolumSecimEkrani;
    

    public GameObject MenuBtn;
    public GameObject Bolum2Kilit;


    void Start()
    {
        GameObject yoneticiobj = GameObject.FindGameObjectWithTag("scoreYansitma");
        scoreYansitma2 = yoneticiobj.GetComponent<ScoreYansitma>();
    }

    
    void Update(){
        if(scoreYansitma2.ilkBolumTamamlandimi==true){
            Debug.Log("1.Bölüm Tamamlandı");
            Bolum2Kilit.SetActive(false);
            
        }
   }
    

    public void PlayBTN(){
        MenuBtn.SetActive(false);
        BolumSecimEkrani.SetActive(true);
    }

    public void BackBTN(){
        MenuBtn.SetActive(true);
        BolumSecimEkrani.SetActive(false);
    }

    public void Quit(){
        Application.Quit();
    }

    public void Level1BTN(){
        SceneManager.LoadScene("Level1");
    }
    public void Level2BTN(){
        SceneManager.LoadScene("Level_2");
    }
}
