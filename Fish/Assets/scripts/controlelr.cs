using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlelr : MonoBehaviour
{

    private Animator animator;
    private Rigidbody playerRb;
    public float jumpforce = 5.6f;
    /* public bool isOnGround = true;*/

    public float groundDistance = 0.2f;
    public LayerMask groundLayer;
    private bool isGrounded;
    AudioManager audioManager;


    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }



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
            animator.SetBool("walkF", true);
            transform.Translate(new Vector3(0, 0, 8f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("walkF", false);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            animator.SetBool("jump", true);
            playerRb.velocity = Vector3.up * jumpforce;
            audioManager.PlaySFX(audioManager.Jump);


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
            animator.SetBool("leftW", true);
            transform.Translate(new Vector3(-8f, 0, 0) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("leftW", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("rightW", true);
            transform.Translate(new Vector3(8f, 0, 0) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("rightW", false);
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


