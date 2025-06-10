using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoganObjelerAlt : MonoBehaviour
{
    public ParticleSystem[] PatlamaEfekti;
    Yonetici yonetici;
    Rigidbody2D rb;
    public float RandomForce;

    
    void Start(){
        rb = GetComponent<Rigidbody2D>();

        RandomForce = Random.Range(10f,13f);

        rb.AddForce(Vector2.up * RandomForce,ForceMode2D.Impulse);

        GameObject yoneticiobj = GameObject.FindGameObjectWithTag("Yonetici");
        yonetici = yoneticiobj.GetComponent<Yonetici>();
    }

    void OnMouseDown(){
        yonetici.Score++;
        Destroy(gameObject);

        int RastgelePatlamaEfekti = Random.Range(0,PatlamaEfekti.Length);
        ParticleSystem secilenPatlamaEfekti = PatlamaEfekti[RastgelePatlamaEfekti];

        ParticleSystem patlatma  = Instantiate(secilenPatlamaEfekti,transform.position,Quaternion.identity);
        patlatma.Play();
    }
}
