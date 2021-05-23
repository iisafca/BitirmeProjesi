using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlavyeKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject yolPrefab;
    [SerializeField]
    GameObject evliyaPrefab;

    GameObject[] yollar = new GameObject[150];

    UIKontrol uikontrol;

    void Start()
    {
        uikontrol = GetComponent<UIKontrol>();
    }

    public void OyunuBaslat()
    {
        uikontrol.OyunBasladi();
        Instantiate(evliyaPrefab, new Vector3(0, -2, 0), Quaternion.identity);

    }

    int sayac = 0, sayac2=0;

    public void EvliyaYukari()
    {
        uikontrol.EvliyaIleri();
        yollar[sayac] = Instantiate(yolPrefab, new Vector3(Random.Range(-5, +5), 6, 0), Quaternion.identity);
        ++sayac;
        if (sayac >= 20)
        {
            Destroy(yollar[sayac2]);
            sayac2++;
        }
    }

    public void EvliyaAsagi()
    {
        uikontrol.EvliyaGeri();
        Destroy(yollar[sayac - 1]);
        sayac -= 1;
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            uikontrol.EvliyaIleri();
            yollar[sayac] = Instantiate(yolPrefab, new Vector3(Random.Range(-5, +5), 6, 0), Quaternion.identity);
            ++sayac;
            if(sayac>=20)
            {
                Destroy(yollar[sayac2]);
                sayac2++;
            }
        }
        
        

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            uikontrol.EvliyaGeri();
            Destroy(yollar[sayac-1]);
            sayac -= 1;
        }
        
        if(sayac == 30)
        {
            uikontrol.OyunuKazandin();
            Destroy(gameObject);
            
            sayac = 0;
        }
    }

    public void OyunuBitir()
    {
        uikontrol.OyunBitti();
        foreach (GameObject yol in yollar)
        {
            yol.GetComponent<HaritaTasarim>().YolYokEt();
        }
        Destroy(gameObject);
        
    }

    
}
