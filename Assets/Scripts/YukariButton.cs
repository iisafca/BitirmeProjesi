using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YukariButton : MonoBehaviour
{
    [SerializeField]
    GameObject yolPrefab;

    
    public void YolAsagi()
    {
        HaritaTasarim.instance.gameObject.transform.position += new Vector3(0, -1, 0);
    }
}
