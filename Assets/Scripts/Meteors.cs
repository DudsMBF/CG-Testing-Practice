using UnityEngine;

public class Meteors : MonoBehaviour
{
    public float speed;
    public float damage;
    private Renderer renderer;
    private Material material;
    private Color materialColor;

    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        renderer = gameObject.GetComponent<Renderer>();
        material = renderer.material;

        Color newColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f),Random.Range(0f, 1f));
        material.SetColor("_BaseColor", newColor);

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
