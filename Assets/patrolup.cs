using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolup : MonoBehaviour
{
    public float speed = 3f; // Скорость движения NPC
    public Transform topBoundary; // Верхняя граница
    public Transform bottomBoundary; // Нижняя граница
    public float boundaryPadding = 0.5f; // Дополнительное расстояние от границы
    private bool movingUp = true; // Флаг направления движения

    void Update()
    {
        if (movingUp && transform.position.y < topBoundary.position.y - boundaryPadding)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime); // Движение вверх
        }
        else if (!movingUp && transform.position.y > bottomBoundary.position.y + boundaryPadding)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime); // Движение вниз
        }
        else
        {
            movingUp = !movingUp; // Изменение направления при достижении границы
        }
    }
}

