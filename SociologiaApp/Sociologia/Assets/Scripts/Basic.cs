using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{
    public static string[] gabarito = new string[8];
    public static int[] dificuldade = new int[8];
    public List<Aluno> alunos = new List<Aluno>();
    public int total_de_alunos;
    public int index = 0; //vai sair somando até chegar em total_de_alunos, dando reload na cena de correção

    void Start()
    {
        
    }

    public static void atualizarInformacoes()
    {
        LerArquivo ler = new LerArquivo();
        gabarito = ler.lerGabarito();
        dificuldade = ler.lerDificuldade();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
