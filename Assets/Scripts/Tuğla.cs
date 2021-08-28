using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuğla : MonoBehaviour
{
    public static int toplamTuğla;
    public Sprite[] tuğlaDizi;
    SpriteRenderer spriteRenderer;
    int maxCarpmaSayisi;
    int carpmaSayisi=0;

    void Start()
    {
        maxCarpmaSayisi = tuğlaDizi.Length+1;
        spriteRenderer = GetComponent<SpriteRenderer>();
        toplamTuğla++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("top"))
        {
            carpmaSayisi++;
            
            if(carpmaSayisi>=maxCarpmaSayisi)
            {
                Destroy(this.gameObject);
                toplamTuğla--;
                if(toplamTuğla<=0)
                {
                    //  GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().SahneDegis();
                    GameObject.Find("OyunKontrol").GetComponent<OyunKontrol>().SahneDegis();
                }
            }
            else
            {
                spriteRenderer.sprite = tuğlaDizi[carpmaSayisi - 1];
                
            }
        }
    }
}
