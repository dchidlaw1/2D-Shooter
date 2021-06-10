using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{

    public GameObject player;
    public float speed = 5.0f;
    private bool running;
    // Start is called before the first frame update
    void Start()
    {
        running = true;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
    
        if(running)
        {
            //run towards the main characters position
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        }


    }

    public void stop()
    {
        running = false;
    }
}
