using UnityEngine;

public class PlayerCollusion : MonoBehaviour{

    public PlayerMovement Movement;
    void OnCollisionEnter(Collision collisionInfo){
       
        if (collisionInfo.collider.tag == "Obstacle"){

            Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
