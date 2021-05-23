using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolaButton : MonoBehaviour
{
    [SerializeField]
    GameObject Evliya;

    
    public void SolEvliya()
    {
        EvliyaKontrol.instance.gameObject.transform.position += new Vector3(-1, 0, 0);
        /*Vector3 position = transform.position;
        Evliya.transform.position += new Vector3(0, 1, 0);
        transform.position = position;*/
    }
}
