using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    Slider slider;
    [SerializeField]
    public float FillSpeed = 0.5f;
    float targetProgress = 0;
    [SerializeField]
    public int tin;
    [SerializeField]
    public GameObject go;
    [SerializeField]
    public float pro;
    int l;
    [SerializeField]
    public int forbck;
    [SerializeField]
    public GameObject win;
    [SerializeField]
    public GameObject g;
    // Start is called before the first frame update
    public void Start()
    {
        forbck = g.GetComponent<Selector>().levelblocks;;
        slider = gameObject.GetComponent<Slider>();
         slider.maxValue = forbck;
    }

    // Update is called once per frame
    void Update()
    {
        tin = go.GetComponent<CommonCounter>().tint;
        if (tin > l)
        {
        IncrementProgress(1);
        }
        l = tin;
        if (slider.value < targetProgress)
            slider.value += FillSpeed * Time.deltaTime;
        if(tin >= forbck)
        {
            win.SetActive(true);
        }
    }
    public void IncrementProgress(int newProgress)
    {
        targetProgress = (int)slider.value + newProgress;
    }
}
