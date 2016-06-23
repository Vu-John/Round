using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour {

    private Controls player;

    void Start () {
        player = FindObjectOfType<Controls>();
    }
	
	void Update () {
	
	}

    // Button Pressed 
    public void LeftArrow() {
        player.moveright = false;
        player.moveleft = true;
    }

    public void RightArrow() {
        player.moveright = true;
        player.moveleft = false;
    }

    public void Jump() {
        player.jump = true;
    }


    // Button Released
    public void ReleaseLeftArrow() {
        player.moveleft = false;
    }

    public void ReleaseRightArrow() {
        player.moveright = false;
    }
}
