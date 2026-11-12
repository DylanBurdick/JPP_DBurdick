using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //movement tuning (editable in inspector)
    public float speed = 5.0f;
    public float turnSpeed;

    //input system action is in inspector for binding keys
    public InputAction MoveAction;

    //current input value
    private Vector2 MoveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //enable MoveAction so it starts reading input
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //reads the 2d vector from the MoveAction (x horizontal y vertical)
        MoveInput = MoveAction.ReadValue<Vector2>();
        //moves the vehicle forward when W is pressed along local Z using y component
        transform.Translate(Vector3.forward * Time.deltaTime * speed * MoveInput.y);

        //rotates the vehicle around local Y (yaw) using x component
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * MoveInput.x);
    }
}
