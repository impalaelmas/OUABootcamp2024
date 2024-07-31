using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    private Animator animator;
    private Rigidbody playerRb;
    public float jumpForce = 4f;
    public float groundDistance = 0.2f;
    public LayerMask groundLayer;
    private bool isGrounded;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundDistance, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }

        HandleMovementAnimations();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 8f) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -8f) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-8f, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(8f, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(new Vector3(0, 0, 8f) * Time.deltaTime);
        }
    }

    private void HandleMovementAnimations()
    {
        animator.SetBool("walk", Input.GetKey(KeyCode.W));
        animator.SetBool("backwalk", Input.GetKey(KeyCode.S));
        animator.SetBool("walkleft", Input.GetKey(KeyCode.A));
        animator.SetBool("walkright", Input.GetKey(KeyCode.D));
        animator.SetBool("run", Input.GetKey(KeyCode.LeftShift));
    }

    private void Jump()
    {
        animator.SetTrigger("jump");
        playerRb.velocity = Vector3.up * jumpForce;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("nextT2"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}