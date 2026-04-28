using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player; 
    public float minX, maxX, minY, maxY;
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(player.position.x, minX, maxX), 
            Mathf.Clamp(player.position.y, minY, maxY), 
            -10);
    }
}
