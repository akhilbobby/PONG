using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    [SerializeField] private float moveSpeed = 100f;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetBall();
    }

    public void ResetBall()
    {
        rigidBody.position = Vector2.zero;
        rigidBody.velocity = Vector2.zero;
        Invoke("StartBall", 2f);
    }

    public void StartBall()
    {
        float x = Random.value > 0.5f ? -1f : 1f;
        float y = Random.value > 0.5f ? Random.Range(-1f, 0) : Random.Range(0, 1f);

        Vector2 startDir = new Vector2(x, y);

        rigidBody.AddForce(startDir * this.moveSpeed);
    }

    public void AddForce(Vector2 force)
    {
        rigidBody.AddForce(force);
    }
}
