using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefabs;
    public GameObject heartPrefab;
    GameObject player;
    public float spawnOffset = 80.0f;
    public float startDelay = 2.0f;
    private float numEnemies;
    // Start is called before the first frame update
    void Start()
    {
        //get the player object
        player = GameObject.Find("Player");
        InvokeRepeating("SpawnRandomEnemy", startDelay, Random.Range(3, 6));
        numEnemies = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomEnemy()
    {
        if(numEnemies < 8)
        {
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);
            float xPos = Random.Range(-113, 116);
            float yPos = Random.Range(-111, 119);
            Instantiate(enemyPrefabs[enemyIndex], new Vector3(xPos, yPos, 0), enemyPrefabs[enemyIndex].transform.rotation);
            numEnemies++;
        }
        
    }

    public void endSpawn()
    {
        CancelInvoke();
    }

    public void removeEnemy()
    {
        numEnemies--;
    }

    public void addHealth(Vector3 pos)
    {
        Instantiate(heartPrefab, pos, heartPrefab.transform.rotation);
    }
}
