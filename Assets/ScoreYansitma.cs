using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreYansitma : MonoBehaviour
{
   public static ScoreYansitma Instance;
   public bool ilkBolumTamamlandimi = false;
   
   

   void Awake(){
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
            return;
        }
   }

   void Update(){
    if(ilkBolumTamamlandimi==true){
        Debug.Log("1.Bölüm Tamamlandı");
        
    }
   }




}
