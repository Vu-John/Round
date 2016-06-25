using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

    public Rigidbody2D player;
    public float movespeed;
    public float jumpheight;

    public bool moveleft;
    public bool moveright;
    public bool jump;

    public int gems;
    private Animator anim;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;

    void Start () {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}

    // Tied to screen refresh rate
    void FixedUpdate() {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    void Update () {
        
        // Load the next level
        if (gems == 10) {
            Application.LoadLevel("level2");
        }

        // Walking used for animation
        if (player.velocity.x != 0 && onGround) {
            anim.SetBool("Walking", true);
        } else {
            anim.SetBool("Walking", false);
        }

        // 
        // Keyboard inputs
        //

        // Left Arrow Key - Allows player to move left
        if (Input.GetKey(KeyCode.LeftArrow)) {
            player.velocity = new Vector2(-movespeed, player.velocity.y);
        }

        // Right Arrow Key - Allows player to move right
        if (Input.GetKey(KeyCode.RightArrow)) {
            player.velocity = new Vector2(movespeed, player.velocity.y);

        }
        // Space Key - Allows player to jump
        if (Input.GetKey(KeyCode.Space)) {
            if (onGround) {
                player.velocity = new Vector2(player.velocity.x, jumpheight);
            }
        }

        //
        // For touch controls
        //
        
        if (moveleft) {
            player.velocity = new Vector2(-movespeed, player.velocity.y);
        }

        if (moveright) {
            player.velocity = new Vector2(movespeed, player.velocity.y);
        }

        if (jump) {
            if (onGround) {
                player.velocity = new Vector2(player.velocity.x, jumpheight);
            }

            jump = false;
        }
    }
}
