using UnityEngine;

public class MovimentoBoss : MonoBehaviour
{
    [SerializeField]public float velocidade = 8f;
    [SerializeField]public float distancia = 3f;

    private bool podeMover;
    private Vector3 posicaoInicial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicaoInicial = transform.localPosition; 
    }

    // Update is called once per frame
    void Update()
    {
        if (!podeMover) return;

        float movimentoX = Mathf.Sin(Time.time  * velocidade) * distancia;
        transform.position = new Vector3(posicaoInicial.x + movimentoX, posicaoInicial.y, posicaoInicial.z);

    }

    public void LigarMovimento()
    {
        podeMover = true;
    }


    public void DesligarMovimento()
    {
        podeMover = false;
        transform.localPosition = posicaoInicial;
    }
}
