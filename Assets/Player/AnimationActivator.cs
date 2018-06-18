using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationActivator : MonoBehaviour {


    private Animator _animator;

    [Header ("Ship Controls")]
    public string ActivateLandingTriggerName;
    public KeyCode keyActivateLanding = KeyCode.Space;

    public string ActivateTurningLeftBoolName;
    public KeyCode keyLeftTurn = KeyCode.LeftArrow;
    public string ActivateTurningRightBoolName;
    public KeyCode keyRightTurn = KeyCode.RightArrow;


    [Header("Capsule Jump")]
    public string ActivateJumpTriggerName;
    public KeyCode keyActivateJump = KeyCode.J;

    // Use this for initialization
    void Start () {
        _animator = GetComponent<Animator>();
    }
    
	// Update is called once per frame
	void Update () {
        //jump for capsule
        if (ActivateJumpTriggerName != "")
        {
            if (Input.GetKeyDown(keyActivateJump))
            {
                _animator.SetTrigger(ActivateJumpTriggerName);
            }
        }

        //land for ship
        if (ActivateLandingTriggerName != "")
        {
            if (Input.GetKeyDown(keyActivateLanding))
            {
                _animator.SetTrigger(ActivateLandingTriggerName);
            }
        }
        
        //left right controls
        if (ActivateTurningLeftBoolName != "" && ActivateTurningRightBoolName != "")
        {
            if (Input.GetKey(keyLeftTurn))
            {
                _animator.SetBool(ActivateTurningLeftBoolName, true);
            }
            else
            {
                _animator.SetBool(ActivateTurningLeftBoolName, false);
            }

            if (Input.GetKey(keyRightTurn))
            {
                _animator.SetBool(ActivateTurningRightBoolName, true);
            }
            else
            {
                _animator.SetBool(ActivateTurningRightBoolName, false);
            }

            //_animator.SetBool(ActivateTurningLeftBoolName, Input.GetKeyDown(keyLeftTurn));

        }



    }
}
