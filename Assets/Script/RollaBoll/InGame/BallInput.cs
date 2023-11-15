using UnityEngine;
using UnityEngine.InputSystem;

public class BallInput : MonoBehaviour
{
    public GameObject Ball;
    // Update is called once per frame
    void Update()
    {
        // �V����Input System���g�p����"W"�L�[�̓��͂����m
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            Ball.transform.position += Vector3.forward;
            
        }
        // W�L�[�������ꑱ���Ă����
        if (Keyboard.current.aKey.isPressed)
        {
            Ball.transform.position += Vector3.left;
        }
        // W�L�[�������ꂽ�u�Ԃ����]������
        if (Keyboard.current.sKey.wasReleasedThisFrame)
        {
            Ball.transform.position += Vector3.back;
            
        }
        if (Keyboard.current.dKey.wasReleasedThisFrame)
        {
            Ball.transform.position += Vector3.right;

        }
    }
}
