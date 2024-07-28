using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlelr : MonoBehaviour
{

    private Animator animator;
    private Rigidbody playerRb;
    public float jumpforce = 4f;
    /* public bool isOnGround = true;*/

    public float groundDistance = 0.2f;
    public LayerMask groundLayer;
    private bool isGrounded;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundDistance, groundLayer);
    }

    private void FixedUpdate()
    {

        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundDistance, groundLayer);



        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("walk", true);
            transform.Translate(new Vector3(0, 0, 8f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("walk", false);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            animator.SetBool("jump", true);
            playerRb.velocity = Vector3.up * jumpforce;



            /*transform.Translate(new Vector3(0, 2f, 0) * Time.deltaTime);*/
        }
        else
        {
            animator.SetBool("jump", false);


        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("backwalk", true);
            transform.Translate(new Vector3(0, 0, -8f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("backwalk", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("walkleft", true);
            transform.Translate(new Vector3(-8f, 0, 0) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("walkleft", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("walkright", true);
            transform.Translate(new Vector3(8f, 0, 0) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("walkright", false);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("run", true);
            transform.Translate(new Vector3(0, 0, 8f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("run", false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "nextT2")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}


