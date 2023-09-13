using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLogic : MonoBehaviour
{
    public float projectileSpeed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveProjectileRight();
    }

    void moveProjectileRight()
    {
        transform.Translate(projectileSpeed,0,0);
    }
}
