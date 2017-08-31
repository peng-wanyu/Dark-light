using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlayerState {//定义公有枚举类型
    Moving,
    Idle
}

public class PlayMove : MonoBehaviour {
    public float speed = 3;
    public PlayerState state = PlayerState.Idle;
    private PlayerDir dir;
    private CharacterController controller;
	// Use this for initialization
	void Start () {
        dir = this.GetComponent<PlayerDir>();
        controller = this.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(dir.targetPosition, transform.position);
        if (distance > 0.3f)
        {
  
            state = PlayerState.Moving;
            controller.SimpleMove(transform.forward * speed);
        }
        else {
          
            state = PlayerState.Idle;
        }
	}
}
