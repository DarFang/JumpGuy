
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameManager gameManager;
    public LayerMask  player;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircle(transform.position, 0.2f, player)) {
            gameManager.addCoin();
            gameObject.SetActive(false);
        }
        
    }
}
