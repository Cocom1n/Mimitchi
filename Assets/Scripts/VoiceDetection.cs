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
        keywords.Add("Baño", CambiarBaño);
        keywords.Add("Cocina", CambiarCocina);
        keywords.Add("Habitacion", CambiarHabitacion);

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
    private void CambiarBaño()
    {
        Debug.Log("Baño");
    }

    private void CambiarCocina()
    {
        Debug.Log("Cocina");
    }

    private void CambiarHabitacion()
    {
        Debug.Log("Habitacion");
    }
}
