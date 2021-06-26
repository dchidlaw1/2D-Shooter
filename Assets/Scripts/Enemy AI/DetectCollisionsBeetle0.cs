using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsBeetle0 : MonoBehaviour
{

    public float HP = 50.0f;
    public float damage = 20.0f;
    private SpawnManager spawner;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet")
        {
            HP -= damage;
            if(HP <= 0)
            {
                Destroy(gameObject);
                spawner.removeEnemy();
                gameManager.addToScore(100);
            }         
            Destroy(collision.gameObject);
        }
        
    }
}
