using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    [SerializeField]private float speed;
    [SerializeField] private float jumpforce;
    [SerializeField] public int jumpnumb = 1;
    private float input;
    public Rigidbody rb;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        // Storing Player's Input
        input = Input.GetAxis("Horizontal");
        //Moving Player
        rb.velocity = new Vector3(input * speed, rb.velocity.y);
        if (input != 0)
        {
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }
        if (input > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (input < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) & jumpnumb >= 1)
        {
            rb.velocity = new Vector3(0, jumpforce, 0);
            jumpnumb -= 1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Floor")
        {
            Debug.Log("HEHE");
            jumpnumb = 1;
        }

    }
}
