using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SavePoints : MonoBehaviour
{
    public int totalPontos;
    public Text contador;

    public GameObject gameOver;

    //Cria um método estático para dar acesso à esta classe
    public static SavePoints acesso;
    // Start is called before the first frame update
    void Start()
    {
        acesso = this;
    }


    public void atualizaPontosText() => contador.text = totalPontos.ToString(); 

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string level)
    {
        SceneManager.LoadScene(level);
    }


}
