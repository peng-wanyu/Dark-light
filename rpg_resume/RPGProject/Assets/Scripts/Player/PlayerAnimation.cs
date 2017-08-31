using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public PlayMove move;

    // Use this for initialization
    void Start()
    {
        move = this.GetComponent<PlayMove>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (move.state == PlayerState.Moving)
        {
            PlayAnim("Run");
        }
        else if (move.state == PlayerState.Moving)
        {
            PlayAnim("Walk");
        }
    }
    void PlayAnim(string animName)
    {
        GetComponent<Animation>().CrossFade(animName);
    }
}
