using UnityEngine;

public class RotateObject : MonoBehaviour
{

    [SerializeField]
    private float xRotation;
    [SerializeField]
    private float yRotation;
    [SerializeField]
    private float zRotation;

    [SerializeField]
    private bool globalRotation;

    // Update is called once per frame
    void Update()
    {
        //rotate object
        if (globalRotation)
        {
            transform.Rotate(xRotation * Time.deltaTime, yRotation * Time.deltaTime, zRotation * Time.deltaTime, Space.World);
        }
        else
        {
            transform.Rotate(xRotation * Time.deltaTime, yRotation * Time.deltaTime, zRotation * Time.deltaTime);
        }

    }
}
