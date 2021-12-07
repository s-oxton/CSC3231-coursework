using UnityEngine;

public class RotateAround : MonoBehaviour
{

    [SerializeField]
    private float xRotationSpeed;
    [SerializeField]
    private float yRotationSpeed;
    [SerializeField]
    private float zRotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.parent.position, transform.parent.right, xRotationSpeed * Time.deltaTime);
        transform.RotateAround(transform.parent.position, transform.parent.up, yRotationSpeed * Time.deltaTime);
        transform.RotateAround(transform.parent.position, transform.parent.forward, zRotationSpeed * Time.deltaTime);
    }
}
