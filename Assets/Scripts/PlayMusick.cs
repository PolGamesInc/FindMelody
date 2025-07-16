using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayMusick : MonoBehaviour
{
    [SerializeField] private InputAction MusickOut;

    [SerializeField] private Image HitBeat;

    private void Start()
    {
        Color colorHitBeat = HitBeat.color;
        colorHitBeat.a = 0f;
        HitBeat.color = colorHitBeat;
    }

    public void MusickPlay()
    {
        Image[] images = GetComponentsInChildren<Image>();

        foreach (Image image in images)
        {
            Color color = image.color;
            color.a = 0f;
            image.color = color;
        }

        TextMeshProUGUI[] textMeshPro = GetComponentsInChildren<TextMeshProUGUI>();

        foreach (TextMeshProUGUI text in textMeshPro)
        {
            Color color = text.color;
            color.a = 0f;
            text.color = color;
        }

        Color colorHitBeat = HitBeat.color;
        colorHitBeat.a = 255f;
        HitBeat.color = colorHitBeat;
    }

    private void OnEnable()
    {
        MusickOut.Enable();
        MusickOut.performed += ctx =>
        {
            Image[] images = GetComponentsInChildren<Image>();

            foreach (Image image in images)
            {
                Color color = image.color;
                color.a = 255f;
                image.color = color;
            }

            TextMeshProUGUI[] textMeshPro = GetComponentsInChildren<TextMeshProUGUI>();

            foreach (TextMeshProUGUI text in textMeshPro)
            {
                Color color = text.color;
                color.a = 255f;
                text.color = color;
            }

            Color colorHitBeat = HitBeat.color;
            colorHitBeat.a = 0f;
            HitBeat.color = colorHitBeat;

            //GameManager.IsActiveGameManager = true;

            GameManager.OneHandred1.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred2.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred3.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred4.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred5.GetComponent<AudioSource>().Stop();

            GameManager.OneHandred12.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred22.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred32.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred42.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred52.GetComponent<AudioSource>().Stop();

            GameManager.OneHandred13.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred23.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred33.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred43.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred53.GetComponent<AudioSource>().Stop();

            GameManager.OneHandred14.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred24.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred34.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred44.GetComponent<AudioSource>().Stop();
            GameManager.OneHandred54.GetComponent<AudioSource>().Stop();


            GameManagerAnswer.OneHandred1.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred2.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred3.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred4.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred5.GetComponent<AudioSource>().Stop();

            GameManagerAnswer.OneHandred12.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred22.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred32.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred42.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred52.GetComponent<AudioSource>().Stop();

            GameManagerAnswer.OneHandred13.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred23.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred33.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred43.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred53.GetComponent<AudioSource>().Stop();

            GameManagerAnswer.OneHandred14.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred24.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred34.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred44.GetComponent<AudioSource>().Stop();
            GameManagerAnswer.OneHandred54.GetComponent<AudioSource>().Stop();
        };
    }
}
