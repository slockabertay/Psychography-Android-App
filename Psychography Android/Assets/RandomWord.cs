using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomWord : MonoBehaviour
{

    public List<string> easyWords = new List<string>();
    public List<string> medWords = new List<string>();
    public List<string> hardWords = new List<string>();
    public List<string> possesion = new List<string>();
    public string output;

    [SerializeField] public TextMeshProUGUI Output;

    // Start is called before the first frame update
    void Start()
    {
        easyWords.Add("test");
        easyWords.Add("test1");

        medWords.Add("test2");
        medWords.Add("test3");

        hardWords.Add("test4");
        hardWords.Add("test5");

        possesion.Add("test 6");
        possesion.Add("test 7");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetEasyText()
    {
        Output.text = getEasyWord();
    }

    public void SetMedText()
    {
        Output.text = getMedWord();
    }

    public void SetHardText()
    {
        Output.text = getHardWord();
    }

    public void SetPosText()
    {
        Output.text = getPos();
    }

    public string getEasyWord()
    {        
        return easyWords[Random.Range(0, easyWords.Count)];
    }

    public string getMedWord()
    {
        return medWords[Random.Range(0, medWords.Count)];
    }

    public string getHardWord()
    {
        return hardWords[Random.Range(0, hardWords.Count)];
    }
    public string getPos()
    {
        return possesion[Random.Range(0, possesion.Count)];
    }
}
