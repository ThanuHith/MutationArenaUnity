using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public GameObject bulletPrefab;
    public Transform firePoint;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
{
    movement.x = Input.GetAxisRaw("Horizontal");
    movement.y = Input.GetAxisRaw("Vertical");

    if (Input.GetKeyDown(KeyCode.Space))
{
    Shoot();
}
}

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

   void Shoot()
{
    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    mousePos.z = 0f;

    Vector2 direction = (mousePos - firePoint.position).normalized;

    GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

    bullet.GetComponent<Bullet>().SetDirection(direction);
}
}