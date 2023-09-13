using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementLogic : MonoBehaviour
{

    public float enemySpeed = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveEnenmyToLeft();
    }

    void moveEnenmyToLeft()
    {
        transform.Translate(-enemySpeed,0,0);
    }
}
