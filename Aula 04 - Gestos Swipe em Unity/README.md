# Aula 4 - Gestos Swipe em Unity

## Vídeo-aula

Link para vídeo aula: 

## Download dos Assets

[Clique Aqui!](https://github.com/Arcaedion/Curso-Jogos-Mobile/raw/master/Aula%2004%20-%20Gestos%20Swipe%20em%20Unity/Aula%204%20-%20Swipe.zip)

## Aula Escrita

Em construção...

## Código da aula:

_ControleJogador.cs_

```cs
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
```
