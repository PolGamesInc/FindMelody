using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private InputAction KeyCodeAlpha1;
    [SerializeField] private InputAction KeyCodeAlpha2;
    [SerializeField] private InputAction KeyCodeAlpha3;
    [SerializeField] private InputAction KeyCodeAlpha4;
    [SerializeField] private InputAction KeyCodeAlpha5;

    [SerializeField] private InputAction KeyCodeAlpha12;
    [SerializeField] private InputAction KeyCodeAlpha22;
    [SerializeField] private InputAction KeyCodeAlpha32;
    [SerializeField] private InputAction KeyCodeAlpha42;
    [SerializeField] private InputAction KeyCodeAlpha52;

    [SerializeField] private InputAction KeyCodeAlpha13;
    [SerializeField] private InputAction KeyCodeAlpha23;
    [SerializeField] private InputAction KeyCodeAlpha33;
    [SerializeField] private InputAction KeyCodeAlpha43;
    [SerializeField] private InputAction KeyCodeAlpha53;

    [SerializeField] private InputAction KeyCodeAlpha14;
    [SerializeField] private InputAction KeyCodeAlpha24;
    [SerializeField] private InputAction KeyCodeAlpha34;
    [SerializeField] private InputAction KeyCodeAlpha44;
    [SerializeField] private InputAction KeyCodeAlpha54;

    public static GameObject OneHandred1;
    public static GameObject OneHandred2;
    public static GameObject OneHandred3;
    public static GameObject OneHandred4;
    public static GameObject OneHandred5;

    public static GameObject OneHandred12;
    public static GameObject OneHandred22;
    public static GameObject OneHandred32;
    public static GameObject OneHandred42;
    public static GameObject OneHandred52;

    public static GameObject OneHandred13;
    public static GameObject OneHandred23;
    public static GameObject OneHandred33;
    public static GameObject OneHandred43;
    public static GameObject OneHandred53;

    public static GameObject OneHandred14;
    public static GameObject OneHandred24;
    public static GameObject OneHandred34;
    public static GameObject OneHandred44;
    public static GameObject OneHandred54;


    [SerializeField] private GameObject CanvasHitBeat;
    [SerializeField] private GameObject CategoryCanvas;
    [SerializeField] private InputAction Pause;
    //public static bool IsActiveGameManager;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        //IsActiveGameManager = true;

        OneHandred1 = GameObject.Find("100/1");
        OneHandred1.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip1;

        OneHandred2 = GameObject.Find("200/1");
        OneHandred2.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip2;

        OneHandred3 = GameObject.Find("300/1");
        OneHandred3.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip3;

        OneHandred4 = GameObject.Find("400/1");
        OneHandred4.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip4;

        OneHandred5 = GameObject.Find("500/1");
        OneHandred5.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip5;


        OneHandred12 = GameObject.Find("100/2");
        OneHandred12.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip12;

        OneHandred22 = GameObject.Find("200/2");
        OneHandred22.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip22;

        OneHandred32 = GameObject.Find("300/2");
        OneHandred32.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip32;

        OneHandred42 = GameObject.Find("400/2");
        OneHandred42.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip42;

        OneHandred52 = GameObject.Find("500/2");
        OneHandred52.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip52;


        OneHandred13 = GameObject.Find("100/3");
        OneHandred13.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip13;

        OneHandred23 = GameObject.Find("200/3");
        OneHandred23.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip23;

        OneHandred33 = GameObject.Find("300/3");
        OneHandred33.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip33;

        OneHandred43 = GameObject.Find("400/3");
        OneHandred43.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip43;

        OneHandred53 = GameObject.Find("500/3");
        OneHandred53.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip53;


        OneHandred14 = GameObject.Find("100/4");
        OneHandred14.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip14;

        OneHandred24 = GameObject.Find("200/4");
        OneHandred24.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip24;

        OneHandred34 = GameObject.Find("300/4");
        OneHandred34.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip34;

        OneHandred44 = GameObject.Find("400/4");
        OneHandred44.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip44;

        OneHandred54 = GameObject.Find("500/4");
        OneHandred54.GetComponent<AudioSource>().clip = AudioLoader.NewSelectedAudioClip54;
    }

    private void OnEnable()
    {
            Pause.Enable();
            Pause.performed += ctx =>
            {
                Debug.Log("Пауза");
                OneHandred1.GetComponent<AudioSource>().Stop();
                OneHandred2.GetComponent<AudioSource>().Stop();
                OneHandred3.GetComponent<AudioSource>().Stop();
                OneHandred4.GetComponent<AudioSource>().Stop();
                OneHandred5.GetComponent<AudioSource>().Stop();

                OneHandred12.GetComponent<AudioSource>().Stop();
                OneHandred22.GetComponent<AudioSource>().Stop();
                OneHandred32.GetComponent<AudioSource>().Stop();
                OneHandred42.GetComponent<AudioSource>().Stop();
                OneHandred52.GetComponent<AudioSource>().Stop();

                OneHandred13.GetComponent<AudioSource>().Stop();
                OneHandred23.GetComponent<AudioSource>().Stop();
                OneHandred33.GetComponent<AudioSource>().Stop();
                OneHandred43.GetComponent<AudioSource>().Stop();
                OneHandred53.GetComponent<AudioSource>().Stop();

                OneHandred14.GetComponent<AudioSource>().Stop();
                OneHandred24.GetComponent<AudioSource>().Stop();
                OneHandred34.GetComponent<AudioSource>().Stop();
                OneHandred44.GetComponent<AudioSource>().Stop();
                OneHandred54.GetComponent<AudioSource>().Stop();
            };

        KeyCodeAlpha1.Enable();
        KeyCodeAlpha1.performed += ctx => { Debug.Log("Нажата клавиша 1"); OneHandred1.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha2.Enable();
        KeyCodeAlpha2.performed += ctx => { Debug.Log("Нажата клавиша 2"); OneHandred2.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha3.Enable();
        KeyCodeAlpha3.performed += ctx => { Debug.Log("Нажата клавиша 3"); OneHandred3.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha4.Enable();
        KeyCodeAlpha4.performed += ctx => { Debug.Log("Нажата клавиша 4"); OneHandred4.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha5.Enable();
        KeyCodeAlpha5.performed += ctx => { Debug.Log("Нажата клавиша 5"); OneHandred5.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };


        KeyCodeAlpha12.Enable();
        KeyCodeAlpha12.performed += ctx => { Debug.Log("Нажата клавиша 12"); OneHandred12.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha22.Enable();
        KeyCodeAlpha22.performed += ctx => { Debug.Log("Нажата клавиша 22"); OneHandred22.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha32.Enable();
        KeyCodeAlpha32.performed += ctx => { Debug.Log("Нажата клавиша 32"); OneHandred32.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha42.Enable();
        KeyCodeAlpha42.performed += ctx => { Debug.Log("Нажата клавиша 42"); OneHandred42.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha52.Enable();
        KeyCodeAlpha52.performed += ctx => { Debug.Log("Нажата клавиша 52"); OneHandred52.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };


        KeyCodeAlpha13.Enable();
        KeyCodeAlpha13.performed += ctx => { Debug.Log("Нажата клавиша 13"); OneHandred13.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha23.Enable();
        KeyCodeAlpha23.performed += ctx => { Debug.Log("Нажата клавиша 23"); OneHandred23.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay();/*IsActiveGameManager = false;*/ };

        KeyCodeAlpha33.Enable();
        KeyCodeAlpha33.performed += ctx => { Debug.Log("Нажата клавиша 33"); OneHandred33.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha43.Enable();
        KeyCodeAlpha43.performed += ctx => { Debug.Log("Нажата клавиша 43"); OneHandred43.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha53.Enable();
        KeyCodeAlpha53.performed += ctx => { Debug.Log("Нажата клавиша 53"); OneHandred53.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };


        KeyCodeAlpha14.Enable();
        KeyCodeAlpha14.performed += ctx => { Debug.Log("Нажата клавиша 14"); OneHandred14.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha24.Enable();
        KeyCodeAlpha24.performed += ctx => { Debug.Log("Нажата клавиша 24"); OneHandred24.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha34.Enable();
        KeyCodeAlpha34.performed += ctx => { Debug.Log("Нажата клавиша 34"); OneHandred34.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha44.Enable();
        KeyCodeAlpha44.performed += ctx => { Debug.Log("Нажата клавиша 44"); OneHandred44.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };

        KeyCodeAlpha54.Enable();
        KeyCodeAlpha54.performed += ctx => { Debug.Log("Нажата клавиша 54"); OneHandred54.GetComponent<AudioSource>().Play(); CategoryCanvas.GetComponent<PlayMusick>().MusickPlay(); /*IsActiveGameManager = false;*/ };
    }

    private void OnDisable()
    {
        KeyCodeAlpha1.performed -= ctx => { Debug.Log("Нажата клавиша 1"); };
        KeyCodeAlpha1.Disable();

        KeyCodeAlpha2.performed -= ctx => { Debug.Log("Нажата клавиша 2"); };
        KeyCodeAlpha2.Disable();

        KeyCodeAlpha3.performed -= ctx => { Debug.Log("Нажата клавиша 3"); };
        KeyCodeAlpha3.Disable();

        KeyCodeAlpha4.performed -= ctx => { Debug.Log("Нажата клавиша 4"); };
        KeyCodeAlpha4.Disable();

        KeyCodeAlpha5.performed -= ctx => { Debug.Log("Нажата клавиша 5"); };
        KeyCodeAlpha5.Disable();


        KeyCodeAlpha12.performed -= ctx => { Debug.Log("Нажата клавиша 12"); };
        KeyCodeAlpha12.Disable();

        KeyCodeAlpha22.performed -= ctx => { Debug.Log("Нажата клавиша 22"); };
        KeyCodeAlpha22.Disable();

        KeyCodeAlpha32.performed -= ctx => { Debug.Log("Нажата клавиша 32"); };
        KeyCodeAlpha32.Disable();

        KeyCodeAlpha42.performed -= ctx => { Debug.Log("Нажата клавиша 42"); };
        KeyCodeAlpha42.Disable();

        KeyCodeAlpha52.performed -= ctx => { Debug.Log("Нажата клавиша 52"); };
        KeyCodeAlpha52.Disable();


        KeyCodeAlpha13.performed -= ctx => { Debug.Log("Нажата клавиша 13"); };
        KeyCodeAlpha13.Disable();

        KeyCodeAlpha23.performed -= ctx => { Debug.Log("Нажата клавиша 23"); };
        KeyCodeAlpha23.Disable();

        KeyCodeAlpha33.performed -= ctx => { Debug.Log("Нажата клавиша 33"); };
        KeyCodeAlpha33.Disable();

        KeyCodeAlpha43.performed -= ctx => { Debug.Log("Нажата клавиша 43"); };
        KeyCodeAlpha43.Disable();

        KeyCodeAlpha53.performed -= ctx => { Debug.Log("Нажата клавиша 53"); };
        KeyCodeAlpha53.Disable();


        KeyCodeAlpha14.performed -= ctx => { Debug.Log("Нажата клавиша 14"); };
        KeyCodeAlpha14.Disable();

        KeyCodeAlpha24.performed -= ctx => { Debug.Log("Нажата клавиша 24"); };
        KeyCodeAlpha24.Disable();

        KeyCodeAlpha34.performed -= ctx => { Debug.Log("Нажата клавиша 34"); };
        KeyCodeAlpha34.Disable();

        KeyCodeAlpha44.performed -= ctx => { Debug.Log("Нажата клавиша 44"); };
        KeyCodeAlpha44.Disable();

        KeyCodeAlpha54.performed -= ctx => { Debug.Log("Нажата клавиша 54"); };
        KeyCodeAlpha54.Disable();
    }

    /*private void Update()
    {
        if(!IsActiveGameManager)
        {
            gameObject.GetComponent<GameManager>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<GameManager>().enabled = true;
        }
    }*/
}