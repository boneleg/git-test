using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    Vector3 inputMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputMovement.Set(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        if (inputMovement.sqrMagnitude > 1f)
            inputMovement.Normalize();

        Vector3 movement = transform.rotation * inputMovement * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}
