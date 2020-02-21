using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingAnimator : MonoBehaviour
{
    public GameObject Player;
    public GameObject animationPlayer;
    Animator ending;
    PlayerMovement playerScript;

    private void Awake()
    {
        ending = gameObject.GetComponent<Animator>();
        playerScript = Player.GetComponent<PlayerMovement>();
    }

    void OnCollisionEnter2D(Collision2D collided)
    {
        if (collided.gameObject.CompareTag("Player")) {
            Destroy(Player);
            animationPlayer.SetActive(true);
            ending.Play("CloseAnimation");
            animationPlayer.GetComponent<Rigidbody2D>().velocity = new Vector3(17, 0, 0);
        }
    }
}
