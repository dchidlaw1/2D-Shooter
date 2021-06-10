using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionPlayer : MonoBehaviour
{

    public float HP = 100.0f;
    public float damage = 20.0f;
    private Vector3 knockBack = new Vector3(-10, 0, 0);
    private GameManager game;
    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("Game Manager").GetComponent<GameManager>();
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
            if (HP <= 0)
            {
                game.GameOver();
            }

            transform.position += knockBack;
        }

    }
}
