using UnityEngine;

public enum MovementState {
    Idle, Flying
}

public class Pigeon : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    // (1) add a member variable to represent the Pigeon's state
    public enum MovementState
    {
        Idle, Flying
    }
    public MovementState pigeonState = MovementState.Idle;
    

    void Update()
    {
        UpdateState();
        UpdateAppearance();
    }

    // (2) fill in this method to update the pigeon's state based on input
    // if the player is pressing the 'A' key, the state should be set to Flying
    // - otherwise, it should be Idle
    private void UpdateState ()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            pigeonState = MovementState.Flying;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            pigeonState = MovementState.Idle;
        }
    }

    // (3) fill in this method to update the pigeon's animation based on its state
    // based on whether the player is Flying or Idling, use the given methods PlayFlyAnimation and PlayIdleAnimation
    // to play the correct animation
    // use a Switch statement!
    private void UpdateAppearance()
    {
        switch(pigeonState)
        {
            case MovementState.Idle:
                PlayIdleAnimation();
                break;

            case MovementState.Flying:
                PlayFlyAnimation();
                break;
        }
    }

    private void PlayFlyAnimation () {
        _animator.SetBool("isFlying", true);
    }

    private void PlayIdleAnimation () {
        _animator.SetBool("isFlying", false);
    }
}
