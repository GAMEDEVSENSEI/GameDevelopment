using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinir : MonoBehaviour
{
    public Yonetici yonetici;
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Meyve")){
            Destroy(col.gameObject);
            yonetici.CanBari--;
        }
    }

}
