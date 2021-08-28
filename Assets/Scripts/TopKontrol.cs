using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopKontrol : MonoBehaviour
{
    public GameObject pedal;
    Rigidbody2D topFizik;
    bool oyunBaslangic = true;

    void Start()
    {
        topFizik = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(oyunBaslangic)
        {
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z);

        }

        if (Input.GetMouseButtonDown(0))
        {
            oyunBaslangic = false;
            topFizik.velocity = Vector2.zero;
            topFizik.AddForce(new Vector2(50, 800));
        }

    }
}
