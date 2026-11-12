using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //movement tuning (editable in inspector)
    public float speed = 5.0f;
    public float turnSpeed;

    //input system action is in inspector for binding keys
    public InputAction moveAction;

    //current input value
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //enable MoveAction so it starts reading input
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //reads the 2d vector from the MoveAction (x horizontal y vertical)
        moveInput = moveAction.ReadValue<Vector2>();
        //moves the vehicle forward when W is pressed along local Z using y component
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

        //rotates the vehicle around local Y (yaw) using x component
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
}
