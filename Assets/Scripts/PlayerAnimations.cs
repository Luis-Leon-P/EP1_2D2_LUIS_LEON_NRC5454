using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator anim;
    private PlayerController Player;
    void Start()
    {
        anim = GetComponent<Animator>();
        Player = GetComponent<PlayerController>();
    }

    void Update()
    {
        switch(Player.playerState)
        {
            case "Idle": anim.SetInteger("State", 0); break;
            case "Run": anim.SetInteger("State", 1); break;
            case "Jump": anim.SetInteger("State", 2); break;
            case "Fall": anim.SetInteger("State", 3); break;
        }
    }
}
