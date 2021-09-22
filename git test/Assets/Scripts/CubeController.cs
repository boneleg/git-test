using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    Vector3 inputMovement;
    Vector3 inputRotation;

    [SerializeField][HideInInspector]
    float movementSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotation
        inputRotation.Set(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0f);

        transform.Rotate(Vector3.right, inputRotation.x);
        transform.Rotate(Vector3.up, inputRotation.y, Space.World);

        // Movement
        inputMovement.Set(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        if (inputMovement.sqrMagnitude > 1f)
            inputMovement.Normalize();

        Vector3 movement = transform.rotation * inputMovement * movementSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}
