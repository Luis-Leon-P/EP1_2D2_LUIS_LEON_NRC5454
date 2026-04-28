using UnityEngine;

public class NPC : MonoBehaviour
{
    public SpriteRenderer PlayerspriteRenderer;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            //this.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            PlayerspriteRenderer.color = Color.red;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            PlayerspriteRenderer.color = Color.white;
        }
    }
}
