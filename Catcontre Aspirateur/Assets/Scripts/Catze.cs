using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class Catze : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private InputAction moveAction;

    private Vector2 moveInput;

    void Start()
    {
        
    }


    void Update()
    {
        GetInput();
        Move();
    }

    private void GetInput() 
    {
     /* movement 1
        moveInput = Vector2.zero;

        if (Keyboard.current == null)
        return; 

            if (Keyboard.current.wKey.isPressed) moveInput.y += 1;
            if (Keyboard.current.sKey.isPressed) moveInput.y -= 1;
            if (Keyboard.current.aKey.isPressed) moveInput.x -= 1;
            if (Keyboard.current.dKey.isPressed) moveInput.x += 1;

            moveInput = moveInput.normalized;
     */


    }
    private void Move()
    {

        /* movement 1
        Vector3 movement = new Vector3(moveInput.x, 0f, moveInput.y);

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
        //transform.position += movement * speed * Time.deltaTime;
        */

        Vector2 input = moveAction.ReadValue<Vector2>();

        Vector3 movement = new Vector3(input.x, 0f, input.y);

        transform.Translate(movement * speed * Time.deltaTime, Space.World);

    }
    private void OnEnable()
    {
        moveAction.Enable();
    }
        private void OnDisable()
    {
        moveAction.Disable();
    }

}
