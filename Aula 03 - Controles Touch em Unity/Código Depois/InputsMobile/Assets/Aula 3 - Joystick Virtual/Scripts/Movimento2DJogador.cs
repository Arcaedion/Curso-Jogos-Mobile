using Arcaedion.DevDasGalaxias;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Controle2D))]
public class Movimento2DJogador : MonoBehaviour
{

    [SerializeField]
    private float _velocidade = 30f;
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private Joystick _joystick;

    private Controle2D _controle;
    private Rigidbody2D _rigidbody;
    private float _movimentoHorizontal;
    private bool _pulando;

    private void Awake()
    {
        _controle = GetComponent<Controle2D>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        //_movimentoHorizontal = Input.GetAxisRaw("Horizontal") * _velocidade;

        if((Input.GetAxisRaw("Horizontal") > 0) || (_joystick.Horizontal > 0))
            _movimentoHorizontal = 1 * _velocidade;
        else if ((Input.GetAxisRaw("Horizontal") < 0) || (_joystick.Horizontal < 0))
            _movimentoHorizontal = -1 * _velocidade;
        else
            _movimentoHorizontal = 0 * _velocidade;

        if (Input.GetButtonDown("Jump"))
        {
            Pula();
        }


        if (_controle.GetEstaNoChao())
        {
            _animator.SetFloat("Velocidade", System.Math.Abs(_rigidbody.velocity.x));
            _animator.SetBool("Pulando", false);
        }
        else
        {
            _animator.SetBool("Pulando", true);
        }
            
    }

    void FixedUpdate()
    {
        _controle.Movimento(_movimentoHorizontal * Time.fixedDeltaTime, _pulando);
        _pulando = false;
    }

    public void Pula()
    {
        _pulando = true;
    }
}
