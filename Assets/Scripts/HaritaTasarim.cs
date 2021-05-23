using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaritaTasarim : MonoBehaviour
{
    public static HaritaTasarim instance;

    
    private void Awake()
    {
        instance = this;
    }

    KlavyeKontrol klavyeKontrol;

    void Start()
    {
        klavyeKontrol = Camera.main.GetComponent<KlavyeKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            position.y -=1;
        }
        transform.position = position;

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            position.y += 1;
        }
        transform.position = position;
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Evliya")
        {
            klavyeKontrol.OyunuBitir();
            YolYokEt();
        }
    }
    public void YolYokEt()
    {
        Debug.Log("yok edildi");
        Destroy(gameObject);
    }
}
