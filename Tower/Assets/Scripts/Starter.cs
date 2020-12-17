using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField]
    public int[] blocks;
    [SerializeField]
    public int levint;
    [SerializeField]
    public int blocint;
    public bool deleteData;
    // Start is called before the first frame update
    void Start()
    {
        levint = PlayerPrefs.GetInt("L");
        levint = PlayerPrefs.GetInt("B");
        if (deleteData)
            PlayerPrefs.DeleteAll();
    }
    public void Game()
    {
        levint = 0;
        blocint = 0;
        PlayerPrefs.SetInt("L",levint);
        PlayerPrefs.SetInt("B", blocint);
        Application.LoadLevel(1);
    }
    public void Outen()
    {
        Application.Quit();
    }
    public void Continuen()
    {
        Application.LoadLevel(1);
    }
}
