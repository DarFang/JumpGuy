using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private float speed = 5f;

    private float horizontal;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;

    public Animator animator;


    private void Update() {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        
        animator.SetBool("isGrounded",IsGroundeed());
    
    }
    public void Jump(InputAction.CallbackContext context){
        if (context.performed && IsGroundeed()){
            Debug.Log("Jump started");
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            animator.SetTrigger("Jump");
        }
        else if(context.canceled && rb.velocity.y >0f){
            Debug.Log("Jump canceled");
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }


    private bool IsGroundeed(){
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private void Flip(){
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }
    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
        animator.SetBool("isRunning", Mathf.Abs(horizontal)>0);
        if (!isFacingRight && horizontal >0f || isFacingRight && horizontal <0f) Flip();
    }
}
