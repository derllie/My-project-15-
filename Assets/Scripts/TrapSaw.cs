using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrapSaw : MonoBehaviour
{
    [SerializeField] private float damage;
    private bool isPlayerAlive = true;
    public Image deathImage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isPlayerAlive && collision.CompareTag("Player"))
        {
            Health playerHealth = collision.GetComponent<Health>();
            playerHealth.TakeDamage(damage);
            AudioManager.instance.PlaySFX("Die");

            if (playerHealth.currentHealth <= 0)
            {
                StartCoroutine(RestartLevelAfterDelay(3f)); // Перезапуск текущей сцены с задержкой
                isPlayerAlive = false; // Помечаем игрока как умершего
                DisablePlayer(collision.gameObject);
                ShowDeathScreen();
            }
        }
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private IEnumerator RestartLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Перезапуск текущей сцены
    }

    private void ShowDeathScreen()
    {
        deathImage.gameObject.SetActive(true);
    }

    private void DisablePlayer(GameObject player)
    {
        Rigidbody2D playerRB = player.GetComponent<Rigidbody2D>();
        playerRB.velocity = Vector2.zero;
        playerRB.gravityScale = 0;
        player.GetComponent<Collider2D>().enabled = false;
    }

    private void OnLevelWasLoaded(int level)
    {
        isPlayerAlive = true; // При загрузке новой сцены устанавливаем игрока как живого
    }
}




