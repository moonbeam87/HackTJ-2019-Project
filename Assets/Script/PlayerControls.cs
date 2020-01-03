using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundCheck;
    public float hiddenObjRadius;
    public LayerMask IsGround;
    private bool onGround;
    private int levelName;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(3, rb.velocity.y);
        onGround = Physics2D.OverlapCircle(groundCheck.position, hiddenObjRadius, IsGround);
        if (Input.GetMouseButtonDown(0) && onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }
        if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene(levelName);
        }

    }

}