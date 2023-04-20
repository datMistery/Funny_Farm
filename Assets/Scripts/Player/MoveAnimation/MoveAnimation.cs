using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    private static MoveAnimation _moveAnimationPlayer;
    public static MoveAnimation MoveAnimationPlayer {
        get
        {
            if (_moveAnimationPlayer == null)
            {
                _moveAnimationPlayer = FindObjectOfType<MoveAnimation>();
            }
            return _moveAnimationPlayer;
        }
    }
    [field:SerializeField] protected Animator _animator;
    public virtual void AnimateMovement(Vector3 direction)
    {
        if (_animator != null)
        {
            if (direction.magnitude > 0)
            {
                _animator.SetBool("isMoving", true);
                _animator.SetFloat("horizontal", direction.x);
                _animator.SetFloat("vertical", direction.y);
            }
            else
            {
                _animator.SetBool("isMoving", false);
            }
        }
    }
}
