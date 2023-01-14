using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    Idle,
    Moving,
    Jumping,
    Swinging,
    Attacking,
    Damaged,
    Riding,
    Boosting,
    Die
}

public class PlayerController : Singleton<PlayerController>
{

    public PlayerState playerState;

    [Header("Variables")]
    [SerializeField] Rigidbody2D rb;

    [Header("Movement Variables")]
    public float speed = 8f;
    float horizontal;
    float vertical;
    bool isFacingRight = true;


    public void Start()
    {
        playerState = PlayerState.Idle;
    }

    public void ChangePlayerState(PlayerState _playerState)
    {
        playerState = _playerState;
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        //if (Input.GetButton("Horizontal"))
        //{
        //    playerState = PlayerState.Moving;
        //    rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        //}

        

        switch (playerState)
        {
            case PlayerState.Idle:
                break;

            case PlayerState.Moving:
                break;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        
    }
}
