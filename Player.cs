using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const float Z = 0f;
    public float speed;
    private Rigidbody2D rig;
    public float JumpForce;
    private bool IsJumping;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
      

        if (Input.GetMouseButtonDown (0) && !IsJumping)
        {
            rig.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            IsJumping = true;
        }

        Move();
    }

    private void OnCollisionEnter2D(Collision2D colisor)
    {
      if(colisor.gameObject.layer == 8)
        {
            IsJumping = false;
        }
    }
    void Move()
    {
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0f, z: 0f);
               transform.position += Movement * Time.deltaTime * speed;
    }
}
