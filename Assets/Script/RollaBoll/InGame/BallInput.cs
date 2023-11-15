using UnityEngine;
using UnityEngine.InputSystem;

public class BallInput : MonoBehaviour
{
    public GameObject Ball;
    // Update is called once per frame
    void Update()
    {
        // 新しいInput Systemを使用して"W"キーの入力を検知
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            Ball.transform.position += Vector3.forward;
            
        }
        // Wキーが押され続けている間
        if (Keyboard.current.aKey.isPressed)
        {
            Ball.transform.position += Vector3.left;
        }
        // Wキーが離された瞬間だけ評価する
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
