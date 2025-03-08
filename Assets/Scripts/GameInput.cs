using UnityEngine;

public class GameInput : MonoBehaviour
{
    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y += 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y -= 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x -= 1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x += 1;
        }
        // 거리값이 1로 고정
        inputVector = inputVector.normalized;
        return inputVector;
    }
}
