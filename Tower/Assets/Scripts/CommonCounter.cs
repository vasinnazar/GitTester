using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommonCounter : MonoBehaviour
{
    [SerializeField]
    public Text tx;
    [SerializeField]
    public Text ltx;
    [SerializeField]
    public int tint;
    [SerializeField]
    public int blocq;
    [SerializeField]
    public int level;
    public int levint;
    int l;
    public GameObject select;
    public GameObject lossPanel;
    // Start is called before the first frame update
    void Start()
    {
      blocq = PlayerPrefs.GetInt("B");
      levint = PlayerPrefs.GetInt("L");
        levint++;
    }

    // Update is called once per frame
    void Update()
    {
        level = select.GetComponent<Selector>().levelblocks;
        tint = GameObject.Find("Parent").GetComponent<Spawner>().children;
        tx.text = blocq.ToString();
        ltx.text = "Level" + levint.ToString();
        if (tint > l)
        {
            blocq++;
        PlayerPrefs.SetInt("B", blocq);
        }
        l = tint;
    }
    public void Win()
    {
        PlayerPrefs.SetInt("L", levint);
        PlayerPrefs.SetInt("B", blocq);
        Application.LoadLevel(1);
    }
    public void Outen()
    {
        Application.LoadLevel(0);
        PlayerPrefs.SetInt("L", levint);
        PlayerPrefs.SetInt("B", blocq);
    }
}
