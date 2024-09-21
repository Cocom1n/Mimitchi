using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceDetection : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();
    void Start()
    {
        keywords.Add("Bañar", Bañar);
        keywords.Add("Alimentar", Comer);
        keywords.Add("Dormir", Dormir);
        keywords.Add("Jugar", Jugar);
        keywords.Add("Despertar", Despertar);

        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        // if the keyword recognized is in our dictionary, call that Action.
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }
    private void Bañar()
    {
        Debug.Log("Se baña");
        GetComponent<Cleaning>().AseoMimitchi(10);
    }

    private void Comer()
    {
        Debug.Log("Come");
        GetComponent<Feeding>().AlimentarMimitchi(10);
    }

    private void Dormir()
    {
        Debug.Log("Duerme");
        GetComponent<Sleeping>().DescansarMimitchi(10);
    }

    private void Jugar()
    {
        Debug.Log("Juega");
    }

    private void Despertar()
    {
        Debug.Log("Se despierta");
    }
}
