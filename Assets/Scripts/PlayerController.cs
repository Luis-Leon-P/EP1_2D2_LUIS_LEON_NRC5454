using System;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed, jumpForce;
    private Vector2 direction;
    public Transform groundCheck;
    public LayerMask layer;
    public bool isGrounded = false;
    public InputActionReference moveAction; // referencia para llamar el inputsystem
    public String playerState = "Idle"; // estado del jugador, por defecto Idle
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        direction = moveAction.action.ReadValue<Vector2>(); // obtenemos el valor del input horizontal
        if(direction.x < 0) transform.localScale = new Vector2(-1,1);
        else if(direction.x > 0) transform.localScale = new Vector2(1,1);

        isGrounded = Physics2D.Linecast(transform.position, groundCheck.position, layer); // verificamos si el jugador esta tocando el suelo con un linecast

        if (Keyboard.current.spaceKey.wasPressedThisFrame && isGrounded == true) // si se presiona espacio, saltamos
        {
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if(isGrounded == true)
        {
            if(direction != Vector2.zero) playerState = "Run"; // si el jugador se mueve, cambiamos el estado a Run
            else if (direction == Vector2.zero) playerState = "Idle"; // si no se mueve, volvemos al estado Idle
        }
        else
        {
            if(rb2d.linearVelocityY > 0) playerState = "Jump"; // si el jugador esta saltando, cambiamos el estado a Jump
            else if(rb2d.linearVelocityY < 0) playerState = "Fall"; // si el jugador esta cayendo, cambiamos el estado a Fall
        }
    }

    void FixedUpdate()
    {
        rb2d.linearVelocity = new Vector2(direction.x * speed, rb2d.linearVelocity.y); // movemos el rigidbody con la velocidad calculada
    }
}
