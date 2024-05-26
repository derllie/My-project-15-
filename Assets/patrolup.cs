using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolup : MonoBehaviour
{
    public float speed = 3f; // �������� �������� NPC
    public Transform topBoundary; // ������� �������
    public Transform bottomBoundary; // ������ �������
    public float boundaryPadding = 0.5f; // �������������� ���������� �� �������
    private bool movingUp = true; // ���� ����������� ��������

    void Update()
    {
        if (movingUp && transform.position.y < topBoundary.position.y - boundaryPadding)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime); // �������� �����
        }
        else if (!movingUp && transform.position.y > bottomBoundary.position.y + boundaryPadding)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime); // �������� ����
        }
        else
        {
            movingUp = !movingUp; // ��������� ����������� ��� ���������� �������
        }
    }
}

