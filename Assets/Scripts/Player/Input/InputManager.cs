using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;
    public static InputManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<InputManager>();
            }
            return _instance;
        }
    }
    private static float _horizontal;
    public static float Horizontal { get => _horizontal; set => _horizontal = value; }
    private static float _vertical;
    public static float Vertical { get => _vertical; set => _vertical = value; }
    public virtual void InputDirection(){
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");
    }
}
