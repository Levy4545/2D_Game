using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public bool alive = true;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public GameObject gameOverMenu;
    public GameObject gameOverlay;
    void OnTriggerEnter2D(Collider2D other)
    {
        gameOverMenu.gameObject.SetActive(true);
        player.transform.position = respawnPoint.transform.position;
    }

    
}
