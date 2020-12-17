using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Measure : MonoBehaviour
{
    [SerializeField]
    public GameObject findchild;
    [SerializeField]
    public float saizY;
    [SerializeField]
    public Spawner spwn = new Spawner();
    [SerializeField]
    public int kids;
    int add;
    [SerializeField]
    public GameObject anchor;
    float anY;
    GameObject parent;
    [SerializeField]
    public float inner;
    [SerializeField]
    public float sec3 = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        parent = GameObject.Find("Parent");
        anchor = GameObject.Find("Anchor");
        anY = anchor.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
      kids = parent.GetComponent<Spawner>().children;
        saizY = findchild.GetComponent<BoxCollider2D>().size.y;
         inner = saizY * kids;
        if (add < kids)
        {
            StartCor();
        }
        add = kids;
    }
    private IEnumerator Corout()
    {
        yield return new WaitForSeconds(sec3);
        anchor.transform.position = new Vector3(0, inner + anY, 0);
    }
    void StartCor()
    {
        StartCoroutine(Corout());
    }
}
