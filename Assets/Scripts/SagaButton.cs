using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SagaButton : MonoBehaviour
{
    [SerializeField]
    GameObject Evliya;
    

    public void SagEvliya()
    {
        EvliyaKontrol.instance.gameObject.transform.position += new Vector3(1, 0, 0);
    }
}
