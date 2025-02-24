using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rb;           // ��������� ������
    private Vector2 moveInput;        // ���� �� ������
    private float moveSpeed = 5f;     // �������� ��������

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // �������� Rigidbody2D
    }

    void FixedUpdate()
    {
        // ��������� �������� � �������������� ������
        rb.linearVelocity = new Vector2(moveInput.x * moveSpeed, rb.linearVelocity.y);
    }
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>(); // Получаем Vector2 (x, y) от ввода
        Debug.Log("Ввод движения: " + moveInput); // Для отладки
    }


}