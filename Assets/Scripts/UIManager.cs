using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Slider Health;
    [SerializeField] TextMeshProUGUI CoinCount;
    void Start()
    {
        SetHealth(1);
        SetCoinCount(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetHealth(float healthPercentage){
        Health.value = healthPercentage;
    }
    public void SetCoinCount(int coinCount){
        CoinCount.text = coinCount.ToString();
    }
}
