using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform attackCheck;
    public LayerMask playerLayer;
    public Transform playerGroundCheck;
    GameManager gameManager;
    [SerializeField] int damage = 15;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics2D.OverlapCircle(attackCheck.position, 0.2f, playerLayer)){
            gameManager.TakeDamage(damage);
        }
        if(Vector3.Distance(transform.position, playerGroundCheck.position)<2.9f){
            Debug.Log("test");
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision other) {
        Debug.Log("test");
    }
}
