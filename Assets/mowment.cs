using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mowment : MonoBehaviour
{

    public float speed;
    public float sensY = 1f;
    public float sensX = 1f;

    CharacterController characterController;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private float jump;

    private Vector3 moveDirection = Vector3.zero;

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Use this for initialization
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * sensX, Input.GetAxis("Mouse X") * sensY, 0f));
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        if (characterController != null && characterController.isGrounded) {
            if (Input.GetButton("Jump"))
            {
                jump = jumpSpeed;
            }
        }
        jump -= gravity * Time.deltaTime;

        Vector3 forward = new Vector3(moveHorizontal, jump, moveVertical) ;
        Vector3 movement = transform.rotation * forward;
        if (characterController != null)
            characterController.Move(Time.deltaTime * movement * speed);


    }
}