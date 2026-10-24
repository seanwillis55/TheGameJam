using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private bool IsGrounded;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            IsGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            IsGrounded = false;
        }
    }

    public bool getGroundCheck()
    {
        return IsGrounded;
    }


}
