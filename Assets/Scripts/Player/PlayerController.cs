using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour   
{
    //variable for movement
    public float speed = 30.0f;
    public Rigidbody2D rb;
    Vector2 movement;
    public GameObject projectilePrefab;
    bool pressed;
    Vector3 offset = new Vector3(3f, 5.5f, 0);
    private bool running;

    // Start is called before the first frame update
    void Start()
    {
        running = true;
    }


   
    // Update is called once per frame
    void Update()
    {
        if(running)
        {
            movement.y = Input.GetAxis("Vertical");
            movement.x = Input.GetAxis("Horizontal");
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(projectilePrefab, transform.position + offset, projectilePrefab.transform.rotation);

            }
        }
        


    }

    void FixedUpdate()
    {
        if(running)
        {
            
            rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
            
        }
        

    }

    public void end()
    {
        running = false;
    } 
}
