using UnityEngine;

public class VirusAI : MonoBehaviour
{
    public float speed = 2f;
    public int damage = 10;
    public float attackCooldown = 1f;

    private float lastAttackTime;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Vector2 direction = player.position - transform.position;
        transform.position += (Vector3)direction.normalized * speed * Time.deltaTime;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Time.time - lastAttackTime > attackCooldown)
            {
                collision.gameObject
                    .GetComponent<PlayerHealth>()
                    .TakeDamage(damage);

                lastAttackTime = Time.time;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(10);
    }
}
}