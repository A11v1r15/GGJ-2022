using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Magnet))]
public class Player : MonoBehaviour
{
    private Magnet _magnet;
    private Rigidbody2D _rigidbody;
    private Controls _controls;
    [SerializeField]
    private Doll _doll;
    private float _movement;
    [SerializeField]
    private float _SPEED;

    public Magnet GetMagnet => _magnet ??= GetComponent<Magnet>();
    public Rigidbody2D GetRigidbody => _rigidbody ??= GetComponent<Rigidbody2D>();

    
    public void Awake()
    {
        _controls = new Controls();
        if (_doll == Doll.MAG){
            _controls.MagNet.MagMove.performed += ctx => Move(ctx);
            _controls.MagNet.MagMove.canceled += ctx => StopMove();
            _controls.MagNet.MagChange.performed += ctx => GetMagnet.Henshin();
        }
        if (_doll == Doll.NET){
            _controls.MagNet.NetMove.performed += ctx => Move(ctx);
            _controls.MagNet.NetMove.canceled += ctx => StopMove();
            _controls.MagNet.NetChange.performed += ctx => GetMagnet.Henshin();
        }
    }
    
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        GetRigidbody.AddForce(Vector2.right * _movement * _SPEED);
    }

    void Move(InputAction.CallbackContext ctx){
        _movement = ctx.ReadValue<float>();
    }
    void StopMove(){
        _movement = 0;
    }

    public void OnEnable()
    {
        _controls.Enable();
    }

    public void OnDisable()
    {
        _controls.Disable();
    }
}

public enum Doll{
    MAG,
    NET
}