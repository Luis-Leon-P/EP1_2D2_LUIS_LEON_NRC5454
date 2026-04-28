using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Invoke("DestroyCoin", 0.5f);
        }
    }

    private void DestroyCoin()
    {
        Destroy(this.gameObject);
    }
}
