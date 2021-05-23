using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yanma : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Yol")
        {
            Debug.Log("yok edildi");
        }
    }
}
