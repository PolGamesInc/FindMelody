using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManagerAnswer : MonoBehaviour
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

    [SerializeField] private InputAction HitBeat;
    [SerializeField] private Image HitBeatImage;
    [SerializeField] private Image HitBeatImageOriginal;
    [SerializeField] private Image ArturPerojkov;
    [SerializeField] private Image Instasamka;
    [SerializeField] private Image OtpetieMosheiniki;
    [SerializeField] private Image Kino;
    [SerializeField] private Image Garik;
    [SerializeField] private Image Mavl;
    [SerializeField] private Image ViaGra;
    [SerializeField] private Image JuliannaKaraylova;
    [SerializeField] private Image Ivanyski;
    [SerializeField] private Image Ymatyrman;
    [SerializeField] private Image OlegGazmanov;
    [SerializeField] private Image Gradysi;
    [SerializeField] private Image MyratNasirov;
    [SerializeField] private Image Kamazz;
    [SerializeField] private Image RokIsland;
    [SerializeField] private Image DimaBilanAndMari;
    [SerializeField] private Image LeonidAgutinAndVladimirPresnikov;
    [SerializeField] private Image NikolaiBaskovAndTaisiaPovali;
    [SerializeField] private Image KostaLakostaAndSerabkina;
    [SerializeField] private Image DjiganNilettoArtickAsti;
    [SerializeField] private Image TatianaKyrtykova;
    [SerializeField] private Image JakoneAndKiliana;
    [SerializeField] private Image BondSKnipkoi;
    [SerializeField] private Image Godzilla;
    [SerializeField] private Image Leprikonsi;
    [SerializeField] private Image MichaelJackson;
    [SerializeField] private Image Karmen;
    [SerializeField] private Image AleksandSerov;
    [SerializeField] private Image Coolio;
    [SerializeField] private Image JannaFriske;
    [SerializeField] private Image ValentinStrikalo;
    [SerializeField] private Image BastaAndMaksim;
    [SerializeField] private Image ChiLi;
    [SerializeField] private Image HiFi;
    [SerializeField] private Image Nirvana;
    [SerializeField] private Image AlisaVereteno;
    [SerializeField] private Image ParkGorkovo;
    [SerializeField] private Image ACDC;
    [SerializeField] private Image IrinaAlegrova;
    [SerializeField] private Image MyagiAndAndshpil;
    [SerializeField] private Image Zivert;
    [SerializeField] private Image YriLoza;
    [SerializeField] private Image Zveri;
    [SerializeField] private Image Basta;
    [SerializeField] private Image SuperJprik;
    [SerializeField] private Image MavikGalibri;
    [SerializeField] private Image Leningrad;
    [SerializeField] private Image FelipKirkorov;
    [SerializeField] private Image RickyMartin;
    [SerializeField] private Image StasMihailov;
    [SerializeField] private Image PresleyElvis;
    [SerializeField] private Image NSYNC;
    [SerializeField] private Image EyeTiger;
    [SerializeField] private Image WillSmith;
    [SerializeField] private Image CarelessWhisper;
    [SerializeField] private Image Shrek;
    [SerializeField] private Image KanyeWest;
    [SerializeField] private Image HandUp;
    [SerializeField] private Image BIS;
    [SerializeField] private Image Bravo;
    [SerializeField] private Image MichailMishystin;
    [SerializeField] private Image AStudio;

    public static TMP_InputField NameArtistA11;
    public static TMP_InputField NameArtistA21;
    public static TMP_InputField NameArtistA31;
    public static TMP_InputField NameArtistA41;
    public static TMP_InputField NameArtistA51;

    public static TMP_InputField NameArtistA12;
    public static TMP_InputField NameArtistA22;
    public static TMP_InputField NameArtistA32;
    public static TMP_InputField NameArtistA42;
    public static TMP_InputField NameArtistA52;

    public static TMP_InputField NameArtistA13;
    public static TMP_InputField NameArtistA23;
    public static TMP_InputField NameArtistA33;
    public static TMP_InputField NameArtistA43;
    public static TMP_InputField NameArtistA53;

    public static TMP_InputField NameArtistA14;
    public static TMP_InputField NameArtistA24;
    public static TMP_InputField NameArtistA34;
    public static TMP_InputField NameArtistA44;
    public static TMP_InputField NameArtistA54;



    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        OneHandred1 = GameObject.Find("100/1A");
        OneHandred1.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip1A;

        OneHandred2 = GameObject.Find("200/1A");
        OneHandred2.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip2A;

        OneHandred3 = GameObject.Find("300/1A");
        OneHandred3.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip3A;

        OneHandred4 = GameObject.Find("400/1A");
        OneHandred4.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip4A;

        OneHandred5 = GameObject.Find("500/1A");
        OneHandred5.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip5A;


        OneHandred12 = GameObject.Find("100/2A");
        OneHandred12.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip12A;

        OneHandred22 = GameObject.Find("200/2A");
        OneHandred22.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip22A;

        OneHandred32 = GameObject.Find("300/2A");
        OneHandred32.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip32A;

        OneHandred42 = GameObject.Find("400/2A");
        OneHandred42.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip42A;

        OneHandred52 = GameObject.Find("500/2A");
        OneHandred52.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip52A;


        OneHandred13 = GameObject.Find("100/3A");
        OneHandred13.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip13A;

        OneHandred23 = GameObject.Find("200/3A");
        OneHandred23.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip23A;

        OneHandred33 = GameObject.Find("300/3A");
        OneHandred33.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip33A;

        OneHandred43 = GameObject.Find("400/3A");
        OneHandred43.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip43A;

        OneHandred53 = GameObject.Find("500/3A");
        OneHandred53.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip53A;


        OneHandred14 = GameObject.Find("100/4A");
        OneHandred14.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip14A;

        OneHandred24 = GameObject.Find("200/4A");
        OneHandred24.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip24A;

        OneHandred34 = GameObject.Find("300/4A");
        OneHandred34.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip34A;

        OneHandred44 = GameObject.Find("400/4A");
        OneHandred44.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip44A;

        OneHandred54 = GameObject.Find("500/4A");
        OneHandred54.GetComponent<AudioSource>().clip = AudioLoaderAnswer.NewSelectedAudioClip54A;
    }

    private void OnEnable()
    {
        HitBeat.Enable();
        HitBeat.performed += ctx => { HitBeatImage.sprite = HitBeatImageOriginal.sprite; };

        KeyCodeAlpha1.Enable();
        KeyCodeAlpha1.performed += ctx => { Debug.Log("������ ������� 1"); OneHandred1.GetComponent<AudioSource>().Play(); GameManager.OneHandred1.GetComponent<AudioSource>().Stop();
            if (NameArtistA11.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA11.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA11.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA11.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA11.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA11.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA11.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA11.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA11.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA11.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA11.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA11.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA11.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA11.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA11.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA11.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA11.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA11.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA11.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA11.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA11.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA11.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA11.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA11.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA11.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA11.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA11.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA11.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA11.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA11.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA11.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA11.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA11.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA11.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA11.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA11.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA11.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA11.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA11.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA11.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA11.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA11.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA11.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA11.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA11.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA11.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA11.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA11.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA11.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA11.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA11.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA11.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA11.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA11.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA11.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA11.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA11.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA11.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA11.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA11.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA11.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA11.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha2.Enable();
        KeyCodeAlpha2.performed += ctx => { Debug.Log("������ ������� 2"); OneHandred2.GetComponent<AudioSource>().Play(); GameManager.OneHandred2.GetComponent<AudioSource>().Stop();
            if (NameArtistA21.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA21.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA21.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA21.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA21.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA21.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA21.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA21.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA21.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA21.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA21.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA21.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA21.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA21.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA21.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA21.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA21.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA21.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA21.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA21.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA21.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA21.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA21.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA21.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA21.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA21.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA21.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA21.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA21.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA21.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA21.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA21.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA21.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA21.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA21.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA21.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA21.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA21.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA21.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA21.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA21.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA21.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA21.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA21.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA21.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA21.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA21.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA21.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA21.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA21.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA21.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA21.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA21.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA21.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA21.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA21.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA21.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA21.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA21.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA21.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA21.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA21.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha3.Enable();
        KeyCodeAlpha3.performed += ctx => { Debug.Log("������ ������� 3"); OneHandred3.GetComponent<AudioSource>().Play(); GameManager.OneHandred3.GetComponent<AudioSource>().Stop();
            if (NameArtistA31.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA31.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA31.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA31.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA31.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA31.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA31.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA31.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA31.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA31.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA31.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA31.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA31.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA31.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA31.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA31.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA31.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA31.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA31.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA31.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA31.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA31.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA31.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA31.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA31.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA31.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA31.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA31.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA31.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA31.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA31.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA31.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA31.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA31.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA31.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA31.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA31.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA31.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA31.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA31.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA31.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA31.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA31.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA31.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA31.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA31.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA31.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA31.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA31.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA31.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA31.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA31.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA31.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA31.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA31.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA31.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA31.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA31.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA31.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA31.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA31.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA31.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha4.Enable();
        KeyCodeAlpha4.performed += ctx => { Debug.Log("������ ������� 4"); OneHandred4.GetComponent<AudioSource>().Play(); GameManager.OneHandred4.GetComponent<AudioSource>().Stop();
            if (NameArtistA41.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA41.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA41.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA41.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA41.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA41.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA41.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA41.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA41.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA41.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA41.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA41.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA41.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA41.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA41.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA41.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA41.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA41.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA41.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA41.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA41.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA41.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA41.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA41.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA41.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA41.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA41.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA41.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA41.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA41.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA41.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA41.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA41.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA41.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA41.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA41.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA41.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA41.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA41.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA41.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA41.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA41.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA41.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA41.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA41.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA41.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA41.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA41.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA41.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA41.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA41.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA41.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA41.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA41.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA41.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA41.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA41.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA41.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA41.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA41.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA41.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA41.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha5.Enable();
        KeyCodeAlpha5.performed += ctx => { Debug.Log("������ ������� 5"); OneHandred5.GetComponent<AudioSource>().Play(); GameManager.OneHandred5.GetComponent<AudioSource>().Stop();
            if (NameArtistA51.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA51.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA51.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA51.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA51.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA51.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA51.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA51.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA51.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA51.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA51.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA51.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA51.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA51.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA51.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA51.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA51.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA51.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA51.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA51.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA51.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA51.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA51.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA51.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA51.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA51.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA51.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA51.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA51.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA51.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA51.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA51.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA51.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA51.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA51.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA51.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA51.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA51.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA51.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA51.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA51.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA51.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA51.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA51.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA51.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA51.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA51.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA51.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA51.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA51.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA51.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA51.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA51.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA51.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA51.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA51.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA51.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA51.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA51.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA51.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA51.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA51.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };


        KeyCodeAlpha12.Enable();
        KeyCodeAlpha12.performed += ctx => { Debug.Log("������ ������� 12"); OneHandred12.GetComponent<AudioSource>().Play(); GameManager.OneHandred12.GetComponent<AudioSource>().Stop();
            if (NameArtistA12.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA12.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA12.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA12.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA12.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA12.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA12.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA12.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA12.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA12.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA12.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA12.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA12.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA12.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA12.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA12.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA12.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA12.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA12.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA12.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA12.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA12.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA12.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA12.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA12.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA12.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA12.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA12.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA12.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA12.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA12.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA12.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA12.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA12.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA12.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA12.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA12.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA12.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA12.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA12.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA12.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA12.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA12.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA12.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA12.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA12.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA12.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA12.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA12.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA12.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA12.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA12.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA12.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA12.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA12.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA12.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA12.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA12.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA12.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA12.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA12.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA12.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha22.Enable();
        KeyCodeAlpha22.performed += ctx => { Debug.Log("������ ������� 22"); OneHandred22.GetComponent<AudioSource>().Play(); GameManager.OneHandred22.GetComponent<AudioSource>().Stop();
            if (NameArtistA22.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA22.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA22.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA22.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA22.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA22.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA22.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA22.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA22.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA22.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA22.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA22.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA22.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA22.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA22.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA22.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA22.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA22.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA22.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA22.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA22.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA22.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA22.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA22.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA22.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA22.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA22.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA22.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA22.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA22.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA22.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA22.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA22.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA22.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA22.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA22.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA22.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA22.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA22.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA22.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA22.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA22.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA22.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA22.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA22.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA22.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA12.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA22.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA22.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA22.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA22.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA22.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA22.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA22.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA22.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA22.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA22.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA22.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA22.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA22.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA22.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA22.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha32.Enable();
        KeyCodeAlpha32.performed += ctx => { Debug.Log("������ ������� 32"); OneHandred32.GetComponent<AudioSource>().Play(); GameManager.OneHandred32.GetComponent<AudioSource>().Stop();
            if (NameArtistA32.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA32.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA32.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA32.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA32.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA32.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA32.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA32.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA32.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA32.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA32.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA32.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA32.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA32.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA32.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA32.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA32.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA32.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA32.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA32.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA32.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA32.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA32.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA32.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA32.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA32.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA32.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA32.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA32.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA32.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA32.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA32.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA32.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA32.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA32.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA32.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA32.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA32.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA32.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA32.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA32.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA32.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA32.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA32.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA32.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA32.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA32.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA32.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA32.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA32.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA32.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA32.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA32.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA32.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA32.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA32.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA32.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA32.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA32.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA32.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA32.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA32.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha42.Enable();
        KeyCodeAlpha42.performed += ctx => { Debug.Log("������ ������� 42"); OneHandred42.GetComponent<AudioSource>().Play(); GameManager.OneHandred42.GetComponent<AudioSource>().Stop();
            if (NameArtistA42.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA42.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA42.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA42.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA42.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA42.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA42.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA42.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA42.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA42.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA42.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA42.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA42.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA42.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA42.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA42.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA42.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA42.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA42.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA42.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA42.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA42.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA42.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA42.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA42.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA42.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA42.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA42.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA42.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA42.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA42.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA42.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA42.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA42.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA42.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA42.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA42.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA42.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA42.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA42.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA42.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA42.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA42.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA42.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA42.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA42.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA42.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA42.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA42.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA42.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA42.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA42.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA42.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA42.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA42.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA42.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA42.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA42.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA42.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA42.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA42.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA42.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha52.Enable();
        KeyCodeAlpha52.performed += ctx => { Debug.Log("������ ������� 52"); OneHandred52.GetComponent<AudioSource>().Play(); GameManager.OneHandred52.GetComponent<AudioSource>().Stop();
            if (NameArtistA52.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA52.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA52.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA52.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA52.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA52.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA52.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA52.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA52.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA52.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA52.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA52.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA52.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA52.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA52.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA52.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA52.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA52.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA52.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA52.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA52.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA52.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA52.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA52.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA52.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA52.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA52.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA52.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA52.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA52.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA52.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA52.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA52.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA52.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA52.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA52.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA52.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA52.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA52.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA52.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA52.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA52.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA52.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA52.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA52.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA52.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA52.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA52.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA52.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA52.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA52.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA52.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA52.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA52.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA52.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA52.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA52.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA52.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA52.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA52.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA52.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA52.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };


        KeyCodeAlpha13.Enable();
        KeyCodeAlpha13.performed += ctx => { Debug.Log("������ ������� 13"); OneHandred13.GetComponent<AudioSource>().Play(); GameManager.OneHandred13.GetComponent<AudioSource>().Stop();
            if (NameArtistA13.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA13.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA13.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA13.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA13.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA13.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA13.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA13.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA13.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA13.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA13.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA13.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA13.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA13.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA13.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA13.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA13.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA13.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA13.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA13.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA13.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA13.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA13.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA13.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA13.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA13.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA13.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA13.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA13.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA13.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA13.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA13.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA13.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA13.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA13.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA13.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA13.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA13.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA13.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA13.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA13.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA13.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA13.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA13.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA13.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA13.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA13.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA13.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA13.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA13.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA13.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA13.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA13.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA13.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA13.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA13.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA13.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA13.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA13.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA13.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA13.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA13.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha23.Enable();
        KeyCodeAlpha23.performed += ctx => { Debug.Log("������ ������� 23"); OneHandred23.GetComponent<AudioSource>().Play(); GameManager.OneHandred23.GetComponent<AudioSource>().Stop();
            if (NameArtistA23.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA23.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA23.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA23.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA23.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA23.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA23.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA23.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA23.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA23.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA23.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA23.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA23.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA23.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA23.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA23.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA23.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA23.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA23.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA23.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA23.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA23.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA23.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA23.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA23.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA23.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA23.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA23.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA23.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA23.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA23.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA23.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA23.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA23.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA23.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA23.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA23.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA23.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA23.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA23.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA23.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA23.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA23.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA23.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA23.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA23.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA23.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA23.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA23.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA23.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA23.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA23.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA23.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA23.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA23.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA23.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA23.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA23.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA23.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA23.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA23.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA23.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha33.Enable();
        KeyCodeAlpha33.performed += ctx => { Debug.Log("������ ������� 33"); OneHandred33.GetComponent<AudioSource>().Play(); GameManager.OneHandred33.GetComponent<AudioSource>().Stop();
            if (NameArtistA33.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA33.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA33.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA33.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA33.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA33.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA33.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA33.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA33.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA33.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA33.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA33.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA33.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA33.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA33.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA33.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA33.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA33.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA33.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA33.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA33.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA33.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA33.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA33.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA33.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA33.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA33.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA33.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA33.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA33.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA33.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA33.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA33.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA33.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA33.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA33.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA33.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA33.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA33.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA33.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA33.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA33.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA33.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA33.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA33.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA33.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA33.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA33.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA33.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA33.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA33.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA33.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA33.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA33.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA33.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA33.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA33.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA33.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA33.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA33.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA33.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA33.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha43.Enable();
        KeyCodeAlpha43.performed += ctx => { Debug.Log("������ ������� 43"); OneHandred43.GetComponent<AudioSource>().Play(); GameManager.OneHandred43.GetComponent<AudioSource>().Stop();
            if (NameArtistA43.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA43.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA43.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA43.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA43.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA43.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA43.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA43.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA43.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA43.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA43.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA43.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA43.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA43.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA43.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA43.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA43.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA43.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA43.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA43.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA43.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA43.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA43.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA43.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA43.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA43.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA43.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA43.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA43.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA43.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA43.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA43.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA43.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA43.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA43.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA43.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA43.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA43.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA43.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA43.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA43.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA43.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA43.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA43.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA43.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA43.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA43.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA43.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA43.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA43.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA43.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA43.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA43.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA43.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA43.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA43.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA43.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA43.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA43.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA43.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA43.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA43.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha53.Enable();
        KeyCodeAlpha53.performed += ctx => { Debug.Log("������ ������� 53"); OneHandred53.GetComponent<AudioSource>().Play(); GameManager.OneHandred53.GetComponent<AudioSource>().Stop();
            if (NameArtistA53.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA53.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA53.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA53.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA53.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA53.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA53.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA53.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA53.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA53.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA53.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA53.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA53.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA53.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA53.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA53.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA53.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA53.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA53.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA53.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA43.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA53.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA53.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA53.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA53.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA53.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA53.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA53.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA53.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA53.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA53.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA53.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA53.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA53.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA53.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA53.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA53.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA53.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA53.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA53.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA53.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA53.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA53.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA53.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA53.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA53.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA53.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA53.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA53.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA53.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA53.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA53.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA53.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA53.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA53.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA53.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA53.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA53.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA53.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA53.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA53.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA53.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };


        KeyCodeAlpha14.Enable();
        KeyCodeAlpha14.performed += ctx => { Debug.Log("������ ������� 14"); OneHandred14.GetComponent<AudioSource>().Play(); GameManager.OneHandred14.GetComponent<AudioSource>().Stop();
            if (NameArtistA14.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA14.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA14.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA14.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA14.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA14.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA14.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA14.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA14.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA14.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA14.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA14.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA14.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA14.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA14.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA14.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA14.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA14.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA14.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA14.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA14.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA14.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA14.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA14.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA14.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA14.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA14.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA14.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA14.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA14.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA14.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA14.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA14.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA14.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA14.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA14.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA14.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA14.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA14.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA14.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA14.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA14.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA14.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA14.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA14.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA14.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA14.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA14.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA14.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA14.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA14.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA14.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA14.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA14.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA14.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA14.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA14.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA14.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA14.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA14.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA14.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA14.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha24.Enable();
        KeyCodeAlpha24.performed += ctx => { Debug.Log("������ ������� 24"); OneHandred24.GetComponent<AudioSource>().Play(); GameManager.OneHandred24.GetComponent<AudioSource>().Stop();
            if (NameArtistA24.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA24.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA24.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA24.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA24.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA24.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA24.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA24.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA24.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA24.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA24.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA24.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA24.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA24.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA24.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA24.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA24.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA24.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA24.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA24.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA24.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA24.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA24.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA24.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA24.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA24.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA24.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA24.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA24.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA24.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA24.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA24.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA24.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA24.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA24.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA24.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA24.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA24.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA24.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA24.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA24.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA24.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA24.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA24.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA24.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA24.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA24.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA24.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA24.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA24.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA24.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA24.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA24.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA24.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA24.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA24.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA24.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA24.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA24.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA24.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA24.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA24.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha34.Enable();
        KeyCodeAlpha34.performed += ctx => { Debug.Log("������ ������� 34"); OneHandred34.GetComponent<AudioSource>().Play(); GameManager.OneHandred34.GetComponent<AudioSource>().Stop();
            if (NameArtistA34.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA34.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA34.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA34.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA34.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA34.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA34.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA34.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA34.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA34.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA34.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA34.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA34.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA34.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA34.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA34.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA34.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA34.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA34.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA34.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA34.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA34.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA34.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA34.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA34.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA34.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA34.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA34.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA34.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA34.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA34.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA34.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA34.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA34.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA34.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA34.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA34.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA34.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA34.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA34.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA34.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA34.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA34.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA34.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA34.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA34.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA34.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA34.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA34.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA34.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA34.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA34.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA34.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA34.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA34.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA34.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA34.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA34.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA34.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA34.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA34.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA34.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha44.Enable();
        KeyCodeAlpha44.performed += ctx => { Debug.Log("������ ������� 44"); OneHandred44.GetComponent<AudioSource>().Play(); GameManager.OneHandred44.GetComponent<AudioSource>().Stop();
            if (NameArtistA44.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA44.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA44.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA44.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA44.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA44.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA44.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA44.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA44.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA44.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA44.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA44.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA44.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA44.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA44.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA44.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA44.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA44.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA44.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA44.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA44.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA44.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA44.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA44.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA44.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA44.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA44.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA44.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA44.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA44.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA44.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA44.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA44.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA44.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA44.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA44.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA44.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA44.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA44.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA44.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA44.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA44.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA44.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA44.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA44.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA44.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA44.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA44.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA44.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA44.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA44.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA44.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA44.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA44.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA44.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA44.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA44.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA44.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA44.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA44.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA44.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA44.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha54.Enable();
        KeyCodeAlpha54.performed += ctx => { Debug.Log("������ ������� 54"); OneHandred54.GetComponent<AudioSource>().Play(); GameManager.OneHandred54.GetComponent<AudioSource>().Stop();
            if (NameArtistA54.text == "����� ��������")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA54.text == "����������")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA54.text == "������� ���������")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA54.text == "����")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA54.text == "����� �������")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA54.text == "����")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA54.text == "��� ���")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA54.text == "������� ���������")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA54.text == "��������")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA54.text == "���������")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA54.text == "���� ��������")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA54.text == "�������")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA54.text == "����� �������")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA54.text == "�����")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA54.text == "��� �������")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA54.text == "���� ����� � ����")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA54.text == "������ ������ � �������� ���������")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA54.text == "������� ������ � ������� �����")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA54.text == "����� ������� � ���������")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA54.text == "����� � ���� � ������ � ������")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA54.text == "������� ���������")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA54.text == "������� � �������")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA54.text == "���� � �������")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA54.text == "�������")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA54.text == "����������")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA54.text == "����� �������")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA54.text == "������")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA54.text == "��������� �����")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA54.text == "�����")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA54.text == "����� ������")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA54.text == "�������� ���������")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA54.text == "����� � ������")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA54.text == "����")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA54.text == "����")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA54.text == "�������")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA54.text == "����� ��������")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA54.text == "���� ��������")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA54.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA54.text == "����� ��������")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA54.text == "����� � ��������")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA54.text == "������")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA54.text == "���� ����")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA54.text == "�����")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA54.text == "�����")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA54.text == "����� �����")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA54.text == "����� � �������")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA54.text == "���������")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA54.text == "������ ���������")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA54.text == "���� ������")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA54.text == "���� ��������")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA54.text == "������ �����")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA54.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA54.text == "����� �����")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA54.text == "��� ����")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA54.text == "������ ������")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA54.text == "����")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA54.text == "����� ����")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA54.text == "���� �����")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA54.text == "���")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA54.text == "�����")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA54.text == "������ ��������")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA54.text == "�������")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };
    }

    private void OnDisable()
    {
        KeyCodeAlpha1.performed -= ctx => { Debug.Log("������ ������� 1"); };
        KeyCodeAlpha1.Disable();

        KeyCodeAlpha2.performed -= ctx => { Debug.Log("������ ������� 2"); };
        KeyCodeAlpha2.Disable();

        KeyCodeAlpha3.performed -= ctx => { Debug.Log("������ ������� 3"); };
        KeyCodeAlpha3.Disable();

        KeyCodeAlpha4.performed -= ctx => { Debug.Log("������ ������� 4"); };
        KeyCodeAlpha4.Disable();

        KeyCodeAlpha5.performed -= ctx => { Debug.Log("������ ������� 5"); };
        KeyCodeAlpha5.Disable();


        KeyCodeAlpha12.performed -= ctx => { Debug.Log("������ ������� 12"); };
        KeyCodeAlpha12.Disable();

        KeyCodeAlpha22.performed -= ctx => { Debug.Log("������ ������� 22"); };
        KeyCodeAlpha22.Disable();

        KeyCodeAlpha32.performed -= ctx => { Debug.Log("������ ������� 32"); };
        KeyCodeAlpha32.Disable();

        KeyCodeAlpha42.performed -= ctx => { Debug.Log("������ ������� 42"); };
        KeyCodeAlpha42.Disable();

        KeyCodeAlpha52.performed -= ctx => { Debug.Log("������ ������� 52"); };
        KeyCodeAlpha52.Disable();


        KeyCodeAlpha13.performed -= ctx => { Debug.Log("������ ������� 13"); };
        KeyCodeAlpha13.Disable();

        KeyCodeAlpha23.performed -= ctx => { Debug.Log("������ ������� 23"); };
        KeyCodeAlpha23.Disable();

        KeyCodeAlpha33.performed -= ctx => { Debug.Log("������ ������� 33"); };
        KeyCodeAlpha33.Disable();

        KeyCodeAlpha43.performed -= ctx => { Debug.Log("������ ������� 43"); };
        KeyCodeAlpha43.Disable();

        KeyCodeAlpha53.performed -= ctx => { Debug.Log("������ ������� 53"); };
        KeyCodeAlpha53.Disable();


        KeyCodeAlpha14.performed -= ctx => { Debug.Log("������ ������� 14"); };
        KeyCodeAlpha14.Disable();

        KeyCodeAlpha24.performed -= ctx => { Debug.Log("������ ������� 24"); };
        KeyCodeAlpha24.Disable();

        KeyCodeAlpha34.performed -= ctx => { Debug.Log("������ ������� 34"); };
        KeyCodeAlpha34.Disable();

        KeyCodeAlpha44.performed -= ctx => { Debug.Log("������ ������� 44"); };
        KeyCodeAlpha44.Disable();

        KeyCodeAlpha54.performed -= ctx => { Debug.Log("������ ������� 54"); };
        KeyCodeAlpha54.Disable();
    }

    /*private void Update()
    {
        if (GameManager.IsActiveGameManager)
        {
            gameObject.GetComponent<GameManagerAnswer>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<GameManagerAnswer>().enabled = true;
        }
    }*/
}