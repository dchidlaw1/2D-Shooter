using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionPlayer : MonoBehaviour
{

    public int HP = 100;
    public int damage = 20;
    private Vector3 knockBack = new Vector3(-10, 0, 0);
    private GameManager game;
    private HealthBar health;
    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("Game Manager").GetComponent<GameManager>();
        health = GameObject.Find("HealthBar").GetComponent<HealthBar>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy1")
        {
            HP -= damage;
            health.SetHealth(HP);
            if (HP <= 0)
            {
                game.GameOver();
            }

            transform.position += knockBack;
        }

    }
}
