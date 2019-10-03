using UnityEngine;
using System.Collections;

public class ControleJogador : MonoBehaviour
{
    [Header("Configurações")]
    [SerializeField]
    private float _rapidez = 1.0f;
    [SerializeField]
    private float _rapidezMudancaDePista = 1.0f;

    [Header("Outros")]
    [SerializeField]
    private Animator _animator;

    private bool _estaCorrendo;
    private int _pistaAtual = 1;
    private bool _pulando;
    private bool _escorregando;
    private Vector3 _posicaoAlvo = Vector3.zero;

    protected void Awake()
    {
        _escorregando = false;
        _estaCorrendo = false;
    }

    public void Inicio()
    {
        _estaCorrendo = false;
        _animator.SetBool("Dead", false);
    }

    public void IniciaCorrida()
    {
        IniciaMovimento();
    }

    public void IniciaMovimento()
    {
        _estaCorrendo = true;
    }

    public void ParaMovimento()
    {
        _estaCorrendo = false;
        if (_animator)
        {
            _animator.SetBool("Moving", false);
        }
    }

    private void Start()
    {
        _estaCorrendo = true;
        if (_animator)
        {
            _animator.Play("runStart");
            _animator.SetBool("Moving", true);
        }
    }
    private bool _swiping = false;
    private Vector2 _iniciandoTouch;

    protected void Update()
    {

        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    MudaPista(-1);
        //}
        //else if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    MudaPista(1);
        //}
        //else if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    StartCoroutine(Pula());
        //}
        //else if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    StartCoroutine(Escorrega());
        //}

        if(Input.touchCount == 1)
        {


            if (_swiping)
            {
                Vector2 diff = Input.GetTouch(0).position - _iniciandoTouch;
                diff = new Vector2(diff.x/Screen.width, diff.y/Screen.width);

                // Magnitude == comprimento entre ponto 0,0 e o vetor2
                if (diff.magnitude > 0.01f) // > 1% = swipe
                {
                    if (Mathf.Abs(diff.y) > Mathf.Abs(diff.x))
                    {
                        if(diff.y < 0)
                        {
                            StartCoroutine(Escorrega());
                        }
                        else
                        {
                            StartCoroutine(Pula());
                        }
                    }
                    else
                    {
                        if (diff.x < 0)
                        {
                            MudaPista(-1);
                        }
                        else
                        {
                            MudaPista(1);
                        }
                    }

                    _swiping = false; // swiping acabou

                }


            }

            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                _iniciandoTouch = Input.GetTouch(0).position;
                _swiping = true;
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                _swiping = false;
            }


        }

        var targ = new Vector3(_posicaoAlvo.x, _posicaoAlvo.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targ, _rapidezMudancaDePista*2 * Time.deltaTime);

    }

    private void FixedUpdate()
    {
        var z = _rapidez * Time.fixedDeltaTime;
        transform.Translate(0, 0, z);
    }


    public IEnumerator Pula()
    {
        if (!_estaCorrendo)
            yield break;

        if (!_pulando)
        {
            _animator.SetFloat("JumpSpeed", 1);
            _animator.SetBool("Jumping", true);
            _pulando = true;
            yield return new WaitForSeconds(0.55f);
            ParaPulo();
        }
    }

    public void ParaPulo()
    {
        if (_pulando)
        {
            _animator.SetBool("Jumping", false);
            _pulando = false;
        }
    }

    public IEnumerator Escorrega()
    {
        if (!_estaCorrendo)
            yield break;

        if (!_escorregando)
        {

            _animator.SetFloat("Sliding", 1);
            _animator.SetBool("Sliding", true);
            _escorregando = true;
            yield return new WaitForSeconds(1f);
            ParaEscorrega();
        }
    }

    public void ParaEscorrega()
    {
        if (_escorregando)
        {
            _animator.SetBool("Sliding", false);
            _escorregando = false;
        }
    }

    public void MudaPista(int direcao)
    {
        if (!_estaCorrendo)
            return;

        _pistaAtual = _pistaAtual + direcao;
        if (_pistaAtual > 2)
            _pistaAtual = 2;
        if (_pistaAtual < 0)
            _pistaAtual = 0;

        int pistaAlvo = _pistaAtual;

        if (pistaAlvo < 0 || pistaAlvo > 2)
            return;

        if(pistaAlvo == 2)
            _posicaoAlvo = new Vector3(3f, 0, 0);
        else if (pistaAlvo == 1)
            _posicaoAlvo = new Vector3(0, 0, 0);
        else if (pistaAlvo == 0)
            _posicaoAlvo = new Vector3(-3f, 0, 0);




    }




}
