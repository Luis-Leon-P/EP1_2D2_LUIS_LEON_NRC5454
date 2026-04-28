using Unity.VisualScripting;
using UnityEngine;

public class Normalizacion : MonoBehaviour
{
    public Transform tank, robot;
    public float speed = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
   
    void Update()
    {
        //Vector2 direcconObjeto = (tank.transform.position - robot.transform.position).normalized;
        //if (tank = null || robot == null) return;
        Vector3 movimiento = (tank.transform.position - robot.transform.position).normalized;
        tank.transform.position += movimiento * speed * Time.deltaTime;
    }
}
