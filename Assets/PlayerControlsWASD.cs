using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControlsWASD : MonoBehaviour
{
    public GameObject projectile;
    public float playerSpeed = 3.0f;
    float maxPlayerY = 8.0f;
    float maxPlayerX = 24f;
    float playerCollisionOffset = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
        keyThenSpawnProjectile();
    }

    void playerMovement()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y <= maxPlayerY)
        {
            transform.Translate(0, playerSpeed, 0);
        }

        if (Input.GetKey(KeyCode.A) && transform.position.x >= -maxPlayerX)
        {
            transform.Translate(-playerSpeed, 0, 0);
        }   

        if (Input.GetKey(KeyCode.S) && transform.position.y >= -maxPlayerY)
        {
            transform.Translate(0, -playerSpeed, 0);
        }

        if (Input.GetKey(KeyCode.D) && transform.position.x <= maxPlayerX)
        {
            transform.Translate(playerSpeed, 0, 0);
        }   
    }

    void keyThenSpawnProjectile()
    {
        if(Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.J) || Input.GetKey(KeyCode.L))
        {
            spawnProjectile();
        }
    }

    void spawnProjectile()
    {
        Instantiate(projectile, new Vector3(transform.position.x + playerCollisionOffset, transform.position.y,0), Quaternion.identity);
    }

    void OnCollisionEnter2D(Collision2D tempCollision)
    {
        if(tempCollision.gameObject.tag == "Collision")
        SceneManager.LoadScene("GameScene");
    }
}
