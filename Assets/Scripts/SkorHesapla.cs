using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkorHesapla : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int skor = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            skor+=10;
            Debug.Log("Score " + skor);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            skor-=10;
            Debug.Log("Score " + skor);
        }

        if (skor == 50)
        {
            Debug.Log("Oyun bitti. Tebrikler!!");
        }


    }
}
