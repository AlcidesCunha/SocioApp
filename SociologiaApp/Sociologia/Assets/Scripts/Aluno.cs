using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aluno : MonoBehaviour
{
    private string respostas;
    private int acertosfacil = 0;
    private int acertosmedio = 0;
    private int acertosdificil = 0;

    public string getRespostas()
    {
        return this.respostas;
    }

    public int getFacil()
    {
        return this.acertosfacil;
    }

    public int getMedio()
    {
        return this.acertosmedio;
    }

    public int getDificil()
    {
        return this.acertosdificil;
    }

    public void setResposta(string respostas)
    {
        this.respostas = respostas;
    }

    public void setFacil()
    {
        this.acertosfacil++;
    }

    public void setMedio()
    {
        this.acertosmedio++;
    }

    public void setDificil()
    {
        this.acertosdificil++;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
