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
        if (GameObject.Find("baño") == null)
        {
            Debug.Log("es otaku bro (ﾉ◕ヮ◕)ﾉ*:･ﾟ✧");
        }
        else
        {
            Debug.Log("Se baña");
            GetComponent<Cleaning>().AseoMimitchi(10);
        }

    }

    private void Comer()
    {
        if (GameObject.Find("cocina cosas") == null)
        {
            Debug.Log("No puede comer en este sitio (✧ω✧)");
        }
        else
        {
            Debug.Log("Come");
            GetComponent<Feeding>().AlimentarMimitchi(10);
        }

    }

    private void Dormir()
    {
        if (GameObject.Find("habitacion paravideos") == null)
        {
            Debug.Log("No quiere dormir ahi (._. )/");
        }
        else
        {
            Debug.Log("Duerme");
            GetComponent<Sleeping>().DescansarMimitchi(10);
        }

    }

    private void Jugar()
    {
        if (GameObject.Find("habitacion paravideos") == null)
        {
            Debug.Log("NO NO NO Jugar (╯°□°）╯︵ ┻━┻");
        }
        else
        {
            Debug.Log("Juega");
        }

    }

    private void Despertar()
    {
        if (GameObject.Find("habitacion paravideos") == null)
        {
            Debug.Log("no esta dormido (≧◡≦)");
        }
        else
        {
            Debug.Log("Se despierta");
        }

    }
}
