using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject oyunAdiText=default;
    [SerializeField]
    GameObject oyunBittiText = default;
    [SerializeField]
    Text puanText = default;
    [SerializeField]
    GameObject oynaButton = default;
    [SerializeField]
    GameObject yukariButton = default;
    [SerializeField]
    GameObject asagiButton = default;
    [SerializeField]
    GameObject solButton = default;
    [SerializeField]
    GameObject sagButton = default;
    [SerializeField]
    GameObject oyunKazandinText = default;

    int puan;
    // Start is called before the first frame update
    void Start()
    {
        oyunBittiText.gameObject.SetActive(false);
        puanText.gameObject.SetActive(false);
        asagiButton.gameObject.SetActive(false);
        yukariButton.gameObject.SetActive(false);
        sagButton.gameObject.SetActive(false);
        solButton.gameObject.SetActive(false);
        oyunKazandinText.gameObject.SetActive(false);
    }

    public void OyunBasladi()
    {
        puan = 0;
        oyunAdiText.gameObject.SetActive(false);
        oynaButton.gameObject.SetActive(false);
        puanText.gameObject.SetActive(true);
        oyunBittiText.gameObject.SetActive(false);

        asagiButton.gameObject.SetActive(true);
        yukariButton.gameObject.SetActive(true);
        sagButton.gameObject.SetActive(true);
        solButton.gameObject.SetActive(true);
        PuaniGuncelle();
    }
    public void OyunuKazandin()
    {
        oyunKazandinText.gameObject.SetActive(true);
        oynaButton.gameObject.SetActive(true);
        asagiButton.gameObject.SetActive(false);
        yukariButton.gameObject.SetActive(false);
        sagButton.gameObject.SetActive(false);
        solButton.gameObject.SetActive(false);
    }

    public void OyunBitti()
    {
        oyunBittiText.gameObject.SetActive(true);
        oynaButton.gameObject.SetActive(true);
        asagiButton.gameObject.SetActive(false);
        yukariButton.gameObject.SetActive(false);
        sagButton.gameObject.SetActive(false);
        solButton.gameObject.SetActive(false);
    }
    void PuaniGuncelle()
    {
        puanText.text = "Puan : " + puan;
    }
    // Update is called once per frame
    public void EvliyaIleri()
    {
        puan += 10;
        PuaniGuncelle();
    }
    public void EvliyaGeri()
    {
        puan -= 10;
        PuaniGuncelle();
    }
}
