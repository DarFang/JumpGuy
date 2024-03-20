using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private List<GameObject> _collectable;
    public LayerMask  player;
    [SerializeField] private GameManager gameManager;

    private void Update() {
        // for (int i = 0; i<_collectable.Count; i++)
        // {
        //     if(Physics2D.OverlapCircle(_collectable[i].transform.position, 0.2f, player)){
        //         _collectable[i].SetActive(false);
        //         gameManager.addCoin();
        //         _collectable.RemoveAt(i);
        //     }
        // } 
    }
}
