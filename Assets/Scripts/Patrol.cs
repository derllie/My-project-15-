using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float speed = 3f; // �������� �������� NPC
    public Transform leftBoundary; // ����� �������
    public Transform rightBoundary; // ������ �������
    public float boundaryPadding = 0.5f; // �������������� ���������� �� �������
    private bool movingRight = true; // ���� ����������� ��������

    void Update()
    {
        if (movingRight && transform.position.x < rightBoundary.position.x - boundaryPadding)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime); // �������� ������
        }
        else if (!movingRight && transform.position.x > leftBoundary.position.x + boundaryPadding)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime); // �������� �����
        }
        else
        {
            movingRight = !movingRight; // ��������� ����������� ��� ���������� �������
        }
    }
}


