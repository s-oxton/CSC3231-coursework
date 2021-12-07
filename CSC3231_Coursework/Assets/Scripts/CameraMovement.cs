using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed;

    private Vector3 transformationVector;

    [SerializeField]
    private Vector2 rotateSpeed;

    private Vector3 rotationVector;

    // Update is called once per frame
    void Update()
    {
        transformationVector = GetTransformationInput();

        TransformCamera(transformationVector);

        if (Input.GetMouseButton(0))
        {
            RotateCamera();
        }

    }

    private Vector3 GetTransformationInput()
    {
        Vector3 transformationVector = new Vector3(0, 0, 0);

        float xMovement = 0, yMovement = 0, zMovement = 0;

        if (Input.GetKey("w"))
        {
            //forwards   
            zMovement += moveSpeed;
        }
        if (Input.GetKey("s"))
        {
            //backwards
            zMovement -= moveSpeed;
        }
        if (Input.GetKey("d"))
        {
            //left
            xMovement += moveSpeed;
        }
        if (Input.GetKey("a"))
        {
            //right
            xMovement -= moveSpeed;
        }
        if (Input.GetKey("q"))
        {
            //up
            yMovement += moveSpeed;
        }
        if (Input.GetKey("e"))
        {
            //down
            yMovement -= moveSpeed;
        }

        xMovement *= Time.deltaTime;
        yMovement *= Time.deltaTime;
        zMovement *= Time.deltaTime;

        transformationVector = new Vector3(xMovement, yMovement, zMovement);

        return transformationVector;
    }

    //moves the camera
    private void TransformCamera(Vector3 transformation)
    {
        transform.localPosition += transformation.z * transform.forward;
        transform.localPosition += transformation.x * transform.right;
        transform.localPosition += transformation.y * transform.up;
        
    }

    //rotate the camera
    private void RotateCamera()
    {
        //get rotation input
        Vector3 rotationInput = GetRotationInput();

        //increase the input with the rotation speed
        rotationInput *= rotateSpeed;

        //modify for time
        rotationVector += rotationInput * Time.deltaTime;

        //update rotation
        transform.eulerAngles = new Vector3(rotationVector.x, rotationVector.y, 0);
    }

    private Vector3 GetRotationInput()
    {
        Vector3 rotationInput = new Vector3(0, 0, 0);
        rotationInput.y += Input.GetAxis("Mouse X");
        rotationInput.x += Input.GetAxis("Mouse Y");
        return rotationInput;
    }


}
