using UnityEngine;
using UnityEngine.InputSystem;

public class BallInput : MonoBehaviour
{
    public BallController ballController;
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            ballController.BallMove(Vector3.forward);
        }
        if (Keyboard.current.aKey.isPressed)
        {
            ballController.BallMove(Vector3.left);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            ballController.BallMove(Vector3.back);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            ballController.BallMove(Vector3.right);
        }
    }
}
