using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Configuration parameters
    [SerializeField] Paddle paddle;

    //state
    Vector2 paddleToBallVector;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(paddle.transform.position.x, paddle.transform.position.y + paddleToBallVector.y);
    }
}
