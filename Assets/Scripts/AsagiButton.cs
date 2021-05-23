using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsagiButton : MonoBehaviour
{
    [SerializeField]
    GameObject yolPrefab;


    public void Yolyukari()
    {
        HaritaTasarim.instance.gameObject.transform.position += new Vector3(0, 1, 0);
    }
}
