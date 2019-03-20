using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LerArquivo : MonoBehaviour
{
    string caminhoreal;
    
    // Start is called before the first frame update
    void Start()
    {
        string caminhoatual = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        Debug.Log(caminhoatual);
        caminhoreal = caminhoatual + "\\Assets\\Arquivos";
    }

    public string[] lerGabarito()
    {
        StreamReader leitor = new StreamReader(caminhoreal);
        string auxgab = leitor.ReadLine();
        leitor.Close();

        string[] gabarito = auxgab.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        return gabarito;
    }

    public int[] lerDificuldade()
    {
        int[] dificuldade = new int[8];

        //Lendo arquivo
        StreamReader leitor = new StreamReader(caminhoreal);
        leitor.ReadLine();
        string auxdif = leitor.ReadLine();

        //Cortando string
        string[] trimm = auxdif.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        //Passando o array de string para um array de int
        for (int i = 0; i < auxdif.Length; i++)
        {
            dificuldade[i] = int.Parse(trimm[i]);
        }
        return dificuldade;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
