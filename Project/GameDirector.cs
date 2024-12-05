using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                                       // UI 사용 시 잊지 않고 추가

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;

    void Start()
    {
        hpGauge = GameObject.Find("hpGauge");
    }
    
    public void DecreaseHP()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}