using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float speed = 3f; // Скорость движения NPC
    public Transform leftBoundary; // Левая граница
    public Transform rightBoundary; // Правая граница
    public float boundaryPadding = 0.5f; // Дополнительное расстояние от границы
    private bool movingRight = true; // Флаг направления движения

    void Update()
    {
        if (movingRight && transform.position.x < rightBoundary.position.x - boundaryPadding)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime); // Движение вправо
        }
        else if (!movingRight && transform.position.x > leftBoundary.position.x + boundaryPadding)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime); // Движение влево
        }
        else
        {
            movingRight = !movingRight; // Изменение направления при достижении границы
        }
    }
}


