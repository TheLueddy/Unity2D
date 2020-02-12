using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Configuration parameters
    [SerializeField] Paddle paddle;
    [SerializeField] float velX;
    [SerializeField] float velY;

    //state
    Vector2 paddleToBallVector;
    bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockBallToPaddle();
            LaunchOnSpacePressed();
        }
    }

    private void LockBallToPaddle()
    {
        transform.position = new Vector2(paddle.transform.position.x, paddle.transform.position.y + paddleToBallVector.y);
    }

    private void LaunchOnSpacePressed()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velX, velY);
            hasStarted = true;
        }
    }
}
