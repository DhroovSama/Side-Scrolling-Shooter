using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyAndProjectile : MonoBehaviour
{
    public GameObject whiteExplosion;
    public GameObject OrangeExplosion;
    
    ScoreLogic addToScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D tempCollision)
    {
        if (tempCollision.gameObject.tag == "Collision")
        {
            spawnParticles(tempCollision.transform.position);
            callScoreLogicScript();
            Destroy(tempCollision.gameObject);
        }

        if (tempCollision.gameObject.tag == "Projectile")
        {
            Destroy(tempCollision.gameObject);
        }
    }

    void callScoreLogicScript()
    {
        addToScore = GameObject.FindGameObjectWithTag ("GUI").GetComponent<ScoreLogic>();
        addToScore.AddToScoreVOID();
    }

    void spawnParticles(Vector2 tempPosition)
    {
        Instantiate(whiteExplosion, tempPosition, Quaternion.identity);
        Instantiate(OrangeExplosion, tempPosition, Quaternion.identity);
    }
}
