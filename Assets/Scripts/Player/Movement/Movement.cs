using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [field: SerializeField] protected float speed = 2f;
    private Vector3 direction;
    private void Update()
    {
        PlayerMovement();
    }
    private void FixedUpdate()
    {
        //move the player
        transform.parent.position += direction * speed * Time.deltaTime;
    }
    public virtual void PlayerMovement()
    {
        if (InputManager.Instance != null)
        {
            InputManager.Instance.InputDirection();
            direction = new Vector3(InputManager.Horizontal, InputManager.Vertical);
            MoveAnimation.MoveAnimationPlayer.AnimateMovement(direction);
        }
    }
}
