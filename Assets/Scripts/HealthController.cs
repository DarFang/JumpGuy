using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float health = 100;
    private float totalHealth;
    bool hasTakenDamage;
    float damageCooldown;
    void Start()
    {
        totalHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if(hasTakenDamage){
            damageCooldown -= Time.deltaTime;
            if(damageCooldown<0){
                hasTakenDamage = false;
            }
        }
    }
    public void TakeDamage(int damage){
        if(!hasTakenDamage){
            health -= damage;
            if(health<=0){
                //we need to code to restart the scene
            }
            hasTakenDamage = true;
            damageCooldown = .5f;
        }
    }
    public float GetPercentageHP(){
        return health/totalHealth;
    }
}
