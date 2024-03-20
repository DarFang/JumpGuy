using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _coinCount;
    UIManager uIManager;
    public HealthController healthController;
    // Start is called before the first frame update
    private void Start() {
        uIManager = FindObjectOfType<UIManager>();
    }
    public void addCoin(){
        _coinCount++;
        uIManager.SetCoinCount(_coinCount);
        Debug.Log("Coin Collected");
    }
    public void TakeDamage(int damage){
        healthController.TakeDamage(damage);
        UpdateHealth();
    }
    public void UpdateHealth(){
        uIManager.SetHealth(healthController.GetPercentageHP());
    }
    
}
