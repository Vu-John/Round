using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
    public Rigidbody2D player;
    public float movespeed;
    public bool moveleft;
    public bool moveright;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        // Left Arrow Key
        if (Input.GetKey(KeyCode.LeftArrow)) {
            player.velocity = new Vector2(-movespeed, player.velocity.y);
        }

        // Right Arrow Key
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.velocity = new Vector2(movespeed, player.velocity.y);

        }

        if (moveleft)
        {
            player.velocity = new Vector2(-movespeed, player.velocity.y);
        }

        if (moveright)
        {
            player.velocity = new Vector2(movespeed, player.velocity.y);
        }
    }
}
