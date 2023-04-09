using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Forest : MonoBehaviour
{
    [Header("Idel")]
    [SerializeField] float idelMovementSpeed;
    [SerializeField] Vector2 idelMovementDirection;

    [Header("AttackUpNDown")]
    [SerializeField] float attackMovementSpeed;
    [SerializeField] Vector2 attackMovementDirection;

    [Header("AttackPlayer")]
    [SerializeField] float attackPlayerSpeed;
    [SerializeField] Transform player;

    [Header("Other")]
    [SerializeField] Transform goundCheckUp;
    [SerializeField] Transform goundCheckDown;
    [SerializeField] Transform goundCheckWall;
    [SerializeField] float groundCheckRadius;
    [SerializeField] LayerMask groundLayer;
    private bool isTouchingUp;
    private bool isTouchingDown;
    private bool isTouchingWall;
    Rigidbody2D rg2d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingUp = Physics2D.OverlapCircle(goundCheckUp.position, groundCheckRadius, groundLayer);
        isTouchingDown = Physics2D.OverlapCircle(goundCheckDown.position, groundCheckRadius, groundLayer);
        isTouchingWall = Physics2D.OverlapCircle(goundCheckWall.position, groundCheckRadius, groundLayer);
    }
}
