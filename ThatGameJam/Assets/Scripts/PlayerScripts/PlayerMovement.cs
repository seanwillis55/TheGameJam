using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string Jump;
    public float speed = 8f;
    public float JumpingPower = 5f;
    private bool IsGrounded;
    //public Animator animator;
    private float Movement;

    Rigidbody2D rb;


    private GroundCheck gc;

    Transform _transform;


    void Start()
    {
        //animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        gc = GameObject.Find("GroundCheck").GetComponent<GroundCheck>();
        _transform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = gc.getGroundCheck();
        Debug.Log("is grounded = " + IsGrounded);
        Movement = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(Movement * speed, rb.linearVelocityY);
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(Jump) && IsGrounded == true)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpingPower);
        }

        //if (Movement > 0)
        //{
        //    animator.SetBool("isWalking", true);
        //    GetComponent<SpriteRenderer>().flipX = false;
        //}
        //else if (Movement <
        //    0)
        //{
        //    animator.SetBool("isWalking", true);
        //    GetComponent<SpriteRenderer>().flipX = true;
        //}
        //else
        //{
        //    animator.SetBool("isWalking", false);
        //}
    }
}
