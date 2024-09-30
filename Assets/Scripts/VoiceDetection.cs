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
        keywords.Add("Hola", Hola);

        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }
    private void Bañar()
    {
        if (GameObject.Find("baño") == null && GetComponent<Sleeping>().GetDormir() == false)
        {
            WindowsVoice.speak("soy otaku bro (ﾉ◕ヮ◕)ﾉ*:･ﾟ✧");
            GetComponent<Animaciones>().Animar(6);
            GameObject.Find("TV").GetComponent<TvController>().ApagarTv();
        }
        else if(GameObject.Find("baño") != null)
        {
            GetComponent<Animaciones>().Animar(1);
            Debug.Log("Se baña");
            GetComponent<Cleaning>().AseoMimitchi(20);
            GetComponent<Sleeping>().RestarSueño(5);
            GetComponent<Feeding>().RestarAlimento(5);
        }

    }

    private void Comer()
    {
        if (GameObject.Find("cocina cosas") == null && GetComponent<Sleeping>().GetDormir() == false)
        {
            WindowsVoice.speak("No puedo comer en este sitio (✧ω✧)");
            GetComponent<Animaciones>().Animar(6);
            GameObject.Find("TV").GetComponent<TvController>().ApagarTv();
        }
        else if(GameObject.Find("cocina cosas") != null)
        {
            GetComponent<Animaciones>().Animar(2);
            Debug.Log("Come");
            GetComponent<Feeding>().AlimentarMimitchi(20);
            GetComponent<Sleeping>().RestarSueño(5);
            GetComponent<Cleaning>().RestarAseo(5);
        }

    }

    private void Dormir()
    {
        if (GameObject.Find("habitacion paravideos") == null && GetComponent<Sleeping>().GetDormir() == false)
        {
            WindowsVoice.speak("No quiero dormir aki (._. )/");
            GetComponent<Animaciones>().Animar(6);
        }
        else if (GameObject.Find("habitacion paravideos") != null)
        {
            GetComponent<Animaciones>().Animar(3);
            GameObject.Find("TV").GetComponent<TvController>().ApagarTv();
            Debug.Log("Duerme");
            GetComponent<Sleeping>().Dormir(true);
            GetComponent<Feeding>().RestarAlimento(5);
        }

    }

    private void Jugar()
    {
        if (GameObject.Find("habitacion paravideos") == null && GetComponent<Sleeping>().GetDormir() == false)
        {
            WindowsVoice.speak("NO NO NO Jugar (╯°□°）╯︵ ┻━┻");
            GetComponent<Animaciones>().Animar(6);
        }
        else if(GameObject.Find("habitacion paravideos") != null && GetComponent<Sleeping>().GetDormir() == false)
        {
            GetComponent<Animaciones>().Animar(4);
            Debug.Log("Juega");
            GameObject.Find("TV").GetComponent<TvController>().EncenderTv();
            GetComponent<Sleeping>().RestarSueño(5);
            GetComponent<Feeding>().RestarAlimento(5);
            GetComponent<Cleaning>().RestarAseo(5);
        }

    }

    private void Despertar()
    {
        if (GameObject.Find("habitacion paravideos") == null && GetComponent<Sleeping>().GetDormir() == false)
        {
            WindowsVoice.speak("no estoy dormido (≧◡≦) uwu");
            GetComponent<Animaciones>().Animar(6);
            GameObject.Find("TV").GetComponent<TvController>().ApagarTv();
        }
        else if(GameObject.Find("habitacion paravideos") != null && GetComponent<Sleeping>().GetDormir() == true)
        {
            GetComponent<Animaciones>().Animar(5);
            Debug.Log("Se despierta");
            GetComponent<Sleeping>().Dormir(false);
        }

    }

    private void Hola()
    {
        if (GetComponent<Sleeping>().GetDormir() == false)
        {
            WindowsVoice.speak("Hello papus, aiam Mimitchi");
            GetComponent<Animaciones>().Animar(7);
            GameObject.Find("TV").GetComponent<TvController>().ApagarTv();
        }

    }
}
