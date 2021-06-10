using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public Button restart;
    private SpawnManager spawn;
    private PlayerController player;
    private GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        spawn.endSpawn();
        restart.gameObject.SetActive(true);
        player.end();
        enemy = GameObject.FindGameObjectsWithTag("Enemy1");
        for(int i = 0; i < enemy.Length; i++)
        {
            enemy[i].GetComponent<ChasePlayer>().stop();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
