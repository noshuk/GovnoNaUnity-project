using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    private void Update()
    {
        Vector3 moveInput = new Vector3(0, 0, Input.GetAxis("Vertical"));

        Quaternion rotation = Quaternion.LookRotation(moveInput);
        rotation.x = 0;
        rotation.y = 0;
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, 0);
        rb.velocity = moveInput * speed;
    }
}
