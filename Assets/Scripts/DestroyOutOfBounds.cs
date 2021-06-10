using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float destOffset = 80.0f;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > player.transform.position.y + destOffset || transform.position.y < player.transform.position.y - destOffset || 
            transform.position.x > player.transform.position.x + destOffset || transform.position.x < player.transform.position.x - destOffset)
        {
            Destroy(gameObject);
        }
    }
}
