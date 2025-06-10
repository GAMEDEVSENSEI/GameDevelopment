using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawmAltTaraf : MonoBehaviour
{
    public GameObject[] SpawmNoktasi;
    public GameObject[] SpawmOlcakObjeler;
    public float SpawmSuresi;


    void Start(){
        StartCoroutine(OblereiSpawmlama());
    }

    IEnumerator OblereiSpawmlama(){
        while(true){
            int rastgeleSpawmIndex = Random.Range(0,SpawmNoktasi.Length);
            GameObject secilenSpawmNoktalari = SpawmNoktasi[rastgeleSpawmIndex];

            int rastgeleObjeIndex = Random.Range(0, SpawmOlcakObjeler.Length);
            GameObject secilenobje = SpawmOlcakObjeler[rastgeleObjeIndex];

            Instantiate(secilenobje,secilenSpawmNoktalari.transform.position,Quaternion.identity);

            yield return new WaitForSeconds(SpawmSuresi);



        }  
    }
}
