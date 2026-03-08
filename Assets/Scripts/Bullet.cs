using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    private Vector2 direction;

    public void SetDirection(Vector2 dir)
    {
        direction = dir;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
{
    if(other.CompareTag("Virus"))
    {
        ScoreManager.AddScore(1);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
}