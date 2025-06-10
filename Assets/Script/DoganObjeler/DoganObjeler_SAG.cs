using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoganObjeler_SAG : MonoBehaviour
{
    public Yonetici yonetici;

    public float Speed;

    public ParticleSystem[] PatlamaEfekti;

    // Start is called before the first frame update
    void Start()
    {
        GameObject yoneticiobj = GameObject.FindGameObjectWithTag("Yonetici");
        yonetici = yoneticiobj.GetComponent<Yonetici>();
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Speed*Time.deltaTime,0,0);
    }

    void OnMouseDown(){
        Destroy(gameObject);
        yonetici.Score++;
        int RastgelePatlamaEfekti = Random.Range(0,PatlamaEfekti.Length);
        ParticleSystem secilenPatlamaEfekti = PatlamaEfekti[RastgelePatlamaEfekti];

        ParticleSystem patlatma  = Instantiate(secilenPatlamaEfekti,transform.position,Quaternion.identity);
        patlatma.Play();
    }
}
