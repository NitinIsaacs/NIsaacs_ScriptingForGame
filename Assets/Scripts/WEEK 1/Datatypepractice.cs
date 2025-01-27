using UnityEngine;

public class Datatypepractice : MonoBehaviour
{
    int a;
    public float b = 4.8f;
    public string chest;
    char brr = 'B';
    float total;
    string fullsentence;
    public string intro;
    public string outro;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        a = 56;
        a = (a + 5) * 2 / (3 - 7);
        Debug.Log(a);

        Debug.Log(b);
        b = b - 2;

        b -= 2;

        Debug.Log("B value is =" + b);

        Debug.Log(brr);

        Debug.Log(intro);
        total = a + b;

        fullsentence = intro + " " + outro;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
