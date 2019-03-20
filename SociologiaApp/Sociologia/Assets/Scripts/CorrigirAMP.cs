using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrigirAMP : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField nomeInput;
    public InputField respostasInput;

    private String getText()
    {
        String x = respostasInput.text;
        return x;
    }

    public void corrigeAMP()
    {
        Basic.atualizarInformacoes();
        String respostas_naocortadas = getText();
        string[] arrayrespostas = GetterSetter.getArray(respostas_naocortadas);
        //Iniciando a correção
        Aluno aluno = new Aluno();
        string[] gabarito = Basic.gabarito;
        int[] dificuldade = Basic.dificuldade;
        int auxindex = 0;
        for (int i = 1; i <= 45; i += 3)
        {
            if (gabarito[auxindex] == arrayrespostas[i])
            {
                switch (dificuldade[i])
                {
                    case 1:
                        aluno.setFacil();
                        break;
                    case 2:
                        aluno.setMedio();
                        break;
                    case 3:
                        aluno.setDificil();
                        break;
                    default:
                        Debug.Log("Dificuldade errada!");
                        break;
                }
                //Pense em algo pra fazer uma estrutura de repetição (ideia abaixo)
                //Criar uma variavel auxiliar no Basic para realoadar a cena enquanto o contador aux
                //(outra variavel de Basic) não atingir o valor e ir adicionando numa List de Alunos
            }
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
