using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Declarations
    [SerializeField] public float speed = 5f;
    [SerializeField] private float jumpforce = 4f;
    public float moveLRDistance = 2f;
    public float moveLRSpeed = 1f;
    public float moveFBDistance = 2f;
    public float moveFBSpeed = 1f;
    private Rigidbody rb;
    private Vector3 moveDirection;
    [SerializeField] private bool isGrounded = false;
    public Vector3 startPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    void Update()
    {
        // Reset movement each frame
        moveDirection = Vector3.zero;

        // Movement input (use GetKey, not GetKeyDown)
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection -= transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection -= transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += transform.right;
        }

        moveDirection = moveDirection.normalized;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);
    }
    void MouseRotator()
    {
        //Rotate the player using the mouse
        float mouseX = Input.GetAxis("Mouse X") * moveLRSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * moveFBSpeed;
        transform.Rotate(Vector3.up * mouseX);
        transform.Rotate(Vector3.left * mouseY);

    }
    void HandleTeleport()
    {
        //Teleport to a random position within a range
        float randomX = Random.Range(-5f, 5f);
        float randomY = Random.Range(0f, 5f);
        float randomZ = Random.Range(-5f, 5f);
        transform.position = new Vector3(randomX, randomY, randomZ);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        /*if (collision.gameObject.CompareTag("Teleporter"))
        {
            HandleTeleport();
        }*/
    }
}
