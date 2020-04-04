using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killbox : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D other)
    {
        // Destroy(other.gameObject);
        GameManager.instance.playerLives -= 1;
        if (GameManager.instance.playerLives <= 3 && GameManager.instance.playerLives >= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
