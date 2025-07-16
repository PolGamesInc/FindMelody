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
        KeyCodeAlpha1.performed += ctx => { Debug.Log("Нажата клавиша 1"); OneHandred1.GetComponent<AudioSource>().Play(); GameManager.OneHandred1.GetComponent<AudioSource>().Stop();
            if (NameArtistA11.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA11.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA11.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA11.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA11.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA11.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA11.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA11.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA11.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA11.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA11.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA11.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA11.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA11.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA11.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA11.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA11.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA11.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA11.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA11.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA11.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA11.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA11.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA11.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA11.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA11.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA11.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA11.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA11.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA11.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA11.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA11.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA11.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA11.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA11.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA11.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA11.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA11.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA11.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA11.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA11.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA11.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA11.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA11.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA11.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA11.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA11.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA11.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA11.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA11.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA11.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA11.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA11.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA11.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA11.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA11.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA11.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA11.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA11.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA11.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA11.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA11.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha2.Enable();
        KeyCodeAlpha2.performed += ctx => { Debug.Log("Нажата клавиша 2"); OneHandred2.GetComponent<AudioSource>().Play(); GameManager.OneHandred2.GetComponent<AudioSource>().Stop();
            if (NameArtistA21.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA21.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA21.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA21.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA21.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA21.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA21.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA21.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA21.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA21.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA21.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA21.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA21.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA21.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA21.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA21.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA21.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA21.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA21.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA21.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA21.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA21.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA21.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA21.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA21.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA21.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA21.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA21.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA21.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA21.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA21.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA21.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA21.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA21.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA21.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA21.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA21.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA21.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA21.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA21.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA21.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA21.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA21.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA21.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA21.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA21.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA21.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA21.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA21.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA21.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA21.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA21.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA21.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA21.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA21.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA21.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA21.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA21.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA21.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA21.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA21.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA21.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha3.Enable();
        KeyCodeAlpha3.performed += ctx => { Debug.Log("Нажата клавиша 3"); OneHandred3.GetComponent<AudioSource>().Play(); GameManager.OneHandred3.GetComponent<AudioSource>().Stop();
            if (NameArtistA31.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA31.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA31.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA31.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA31.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA31.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA31.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA31.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA31.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA31.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA31.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA31.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA31.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA31.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA31.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA31.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA31.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA31.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA31.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA31.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA31.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA31.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA31.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA31.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA31.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA31.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA31.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA31.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA31.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA31.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA31.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA31.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA31.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA31.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA31.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA31.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA31.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA31.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA31.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA31.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA31.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA31.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA31.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA31.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA31.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA31.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA31.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA31.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA31.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA31.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA31.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA31.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA31.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA31.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA31.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA31.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA31.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA31.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA31.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA31.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA31.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA31.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha4.Enable();
        KeyCodeAlpha4.performed += ctx => { Debug.Log("Нажата клавиша 4"); OneHandred4.GetComponent<AudioSource>().Play(); GameManager.OneHandred4.GetComponent<AudioSource>().Stop();
            if (NameArtistA41.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA41.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA41.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA41.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA41.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA41.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA41.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA41.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA41.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA41.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA41.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA41.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA41.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA41.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA41.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA41.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA41.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA41.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA41.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA41.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA41.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA41.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA41.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA41.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA41.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA41.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA41.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA41.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA41.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA41.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA41.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA41.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA41.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA41.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA41.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA41.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA41.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA41.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA41.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA41.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA41.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA41.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA41.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA41.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA41.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA41.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA41.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA41.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA41.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA41.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA41.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA41.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA41.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA41.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA41.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA41.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA41.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA41.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA41.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA41.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA41.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA41.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha5.Enable();
        KeyCodeAlpha5.performed += ctx => { Debug.Log("Нажата клавиша 5"); OneHandred5.GetComponent<AudioSource>().Play(); GameManager.OneHandred5.GetComponent<AudioSource>().Stop();
            if (NameArtistA51.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA51.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA51.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA51.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA51.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA51.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA51.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA51.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA51.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA51.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA51.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA51.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA51.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA51.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA51.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA51.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA51.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA51.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA51.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA51.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA51.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA51.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA51.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA51.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA51.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA51.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA51.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA51.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA51.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA51.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA51.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA51.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA51.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA51.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA51.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA51.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA51.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA51.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA51.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA51.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA51.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA51.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA51.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA51.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA51.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA51.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA51.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA51.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA51.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA51.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA51.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA51.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA51.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA51.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA51.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA51.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA51.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA51.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA51.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA51.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA51.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA51.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };


        KeyCodeAlpha12.Enable();
        KeyCodeAlpha12.performed += ctx => { Debug.Log("Нажата клавиша 12"); OneHandred12.GetComponent<AudioSource>().Play(); GameManager.OneHandred12.GetComponent<AudioSource>().Stop();
            if (NameArtistA12.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA12.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA12.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA12.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA12.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA12.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA12.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA12.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA12.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA12.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA12.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA12.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA12.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA12.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA12.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA12.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA12.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA12.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA12.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA12.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA12.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA12.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA12.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA12.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA12.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA12.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA12.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA12.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA12.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA12.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA12.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA12.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA12.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA12.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA12.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA12.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA12.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA12.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA12.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA12.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA12.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA12.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA12.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA12.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA12.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA12.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA12.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA12.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA12.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA12.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA12.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA12.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA12.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA12.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA12.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA12.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA12.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA12.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA12.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA12.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA12.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA12.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha22.Enable();
        KeyCodeAlpha22.performed += ctx => { Debug.Log("Нажата клавиша 22"); OneHandred22.GetComponent<AudioSource>().Play(); GameManager.OneHandred22.GetComponent<AudioSource>().Stop();
            if (NameArtistA22.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA22.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA22.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA22.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA22.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA22.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA22.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA22.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA22.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA22.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA22.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA22.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA22.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA22.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA22.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA22.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA22.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA22.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA22.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA22.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA22.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA22.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA22.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA22.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA22.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA22.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA22.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA22.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA22.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA22.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA22.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA22.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA22.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA22.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA22.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA22.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA22.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA22.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA22.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA22.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA22.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA22.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA22.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA22.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA22.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA22.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA12.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA22.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA22.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA22.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA22.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA22.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA22.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA22.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA22.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA22.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA22.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA22.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA22.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA22.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA22.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA22.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha32.Enable();
        KeyCodeAlpha32.performed += ctx => { Debug.Log("Нажата клавиша 32"); OneHandred32.GetComponent<AudioSource>().Play(); GameManager.OneHandred32.GetComponent<AudioSource>().Stop();
            if (NameArtistA32.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA32.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA32.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA32.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA32.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA32.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA32.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA32.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA32.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA32.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA32.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA32.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA32.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA32.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA32.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA32.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA32.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA32.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA32.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA32.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA32.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA32.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA32.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA32.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA32.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA32.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA32.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA32.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA32.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA32.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA32.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA32.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA32.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA32.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA32.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA32.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA32.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA32.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA32.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA32.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA32.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA32.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA32.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA32.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA32.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA32.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA32.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA32.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA32.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA32.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA32.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA32.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA32.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA32.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA32.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA32.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA32.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA32.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA32.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA32.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA32.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA32.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha42.Enable();
        KeyCodeAlpha42.performed += ctx => { Debug.Log("Нажата клавиша 42"); OneHandred42.GetComponent<AudioSource>().Play(); GameManager.OneHandred42.GetComponent<AudioSource>().Stop();
            if (NameArtistA42.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA42.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA42.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA42.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA42.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA42.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA42.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA42.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA42.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA42.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA42.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA42.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA42.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA42.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA42.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA42.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA42.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA42.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA42.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA42.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA42.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA42.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA42.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA42.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA42.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA42.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA42.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA42.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA42.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA42.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA42.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA42.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA42.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA42.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA42.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA42.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA42.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA42.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA42.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA42.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA42.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA42.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA42.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA42.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA42.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA42.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA42.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA42.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA42.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA42.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA42.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA42.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA42.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA42.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA42.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA42.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA42.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA42.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA42.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA42.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA42.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA42.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha52.Enable();
        KeyCodeAlpha52.performed += ctx => { Debug.Log("Нажата клавиша 52"); OneHandred52.GetComponent<AudioSource>().Play(); GameManager.OneHandred52.GetComponent<AudioSource>().Stop();
            if (NameArtistA52.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA52.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA52.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA52.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA52.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA52.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA52.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA52.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA52.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA52.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA52.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA52.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA52.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA52.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA52.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA52.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA52.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA52.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA52.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA52.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA52.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA52.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA52.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA52.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA52.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA52.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA52.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA52.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA52.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA52.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA52.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA52.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA52.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA52.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA52.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA52.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA52.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA52.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA52.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA52.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA52.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA52.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA52.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA52.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA52.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA52.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA52.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA52.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA52.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA52.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA52.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA52.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA52.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA52.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA52.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA52.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA52.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA52.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA52.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA52.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA52.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA52.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };


        KeyCodeAlpha13.Enable();
        KeyCodeAlpha13.performed += ctx => { Debug.Log("Нажата клавиша 13"); OneHandred13.GetComponent<AudioSource>().Play(); GameManager.OneHandred13.GetComponent<AudioSource>().Stop();
            if (NameArtistA13.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA13.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA13.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA13.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA13.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA13.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA13.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA13.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA13.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA13.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA13.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA13.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA13.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA13.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA13.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA13.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA13.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA13.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA13.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA13.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA13.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA13.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA13.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA13.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA13.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA13.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA13.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA13.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA13.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA13.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA13.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA13.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA13.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA13.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA13.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA13.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA13.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA13.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA13.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA13.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA13.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA13.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA13.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA13.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA13.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA13.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA13.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA13.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA13.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA13.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA13.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA13.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA13.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA13.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA13.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA13.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA13.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA13.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA13.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA13.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA13.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA13.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha23.Enable();
        KeyCodeAlpha23.performed += ctx => { Debug.Log("Нажата клавиша 23"); OneHandred23.GetComponent<AudioSource>().Play(); GameManager.OneHandred23.GetComponent<AudioSource>().Stop();
            if (NameArtistA23.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA23.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA23.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA23.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA23.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA23.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA23.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA23.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA23.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA23.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA23.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA23.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA23.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA23.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA23.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA23.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA23.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA23.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA23.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA23.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA23.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA23.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA23.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA23.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA23.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA23.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA23.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA23.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA23.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA23.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA23.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA23.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA23.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA23.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA23.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA23.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA23.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA23.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA23.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA23.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA23.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA23.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA23.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA23.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA23.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA23.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA23.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA23.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA23.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA23.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA23.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA23.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA23.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA23.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA23.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA23.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA23.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA23.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA23.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA23.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA23.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA23.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha33.Enable();
        KeyCodeAlpha33.performed += ctx => { Debug.Log("Нажата клавиша 33"); OneHandred33.GetComponent<AudioSource>().Play(); GameManager.OneHandred33.GetComponent<AudioSource>().Stop();
            if (NameArtistA33.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA33.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA33.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA33.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA33.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA33.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA33.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA33.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA33.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA33.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA33.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA33.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA33.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA33.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA33.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA33.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA33.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA33.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA33.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA33.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA33.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA33.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA33.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA33.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA33.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA33.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA33.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA33.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA33.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA33.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA33.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA33.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA33.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA33.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA33.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA33.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA33.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA33.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA33.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA33.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA33.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA33.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA33.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA33.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA33.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA33.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA33.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA33.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA33.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA33.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA33.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA33.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA33.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA33.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA33.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA33.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA33.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA33.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA33.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA33.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA33.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA33.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha43.Enable();
        KeyCodeAlpha43.performed += ctx => { Debug.Log("Нажата клавиша 43"); OneHandred43.GetComponent<AudioSource>().Play(); GameManager.OneHandred43.GetComponent<AudioSource>().Stop();
            if (NameArtistA43.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA43.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA43.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA43.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA43.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA43.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA43.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA43.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA43.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA43.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA43.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA43.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA43.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA43.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA43.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA43.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA43.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA43.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA43.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA43.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA43.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA43.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA43.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA43.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA43.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA43.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA43.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA43.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA43.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA43.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA43.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA43.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA43.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA43.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA43.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA43.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA43.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA43.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA43.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA43.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA43.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA43.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA43.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA43.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA43.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA43.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA43.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA43.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA43.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA43.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA43.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA43.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA43.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA43.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA43.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA43.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA43.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA43.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA43.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA43.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA43.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA43.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha53.Enable();
        KeyCodeAlpha53.performed += ctx => { Debug.Log("Нажата клавиша 53"); OneHandred53.GetComponent<AudioSource>().Play(); GameManager.OneHandred53.GetComponent<AudioSource>().Stop();
            if (NameArtistA53.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA53.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA53.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA53.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA53.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA53.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA53.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA53.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA53.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA53.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA53.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA53.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA53.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA53.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA53.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA53.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA53.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA53.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA53.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA53.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA43.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA53.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA53.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA53.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA53.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA53.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA53.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA53.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA53.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA53.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA53.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA53.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA53.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA53.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA53.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA53.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA53.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA53.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA53.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA53.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA53.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA53.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA53.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA53.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA53.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA53.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA53.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA53.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA53.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA53.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA53.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA53.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA53.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA53.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA53.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA53.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA53.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA53.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA53.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA53.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA53.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA53.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };


        KeyCodeAlpha14.Enable();
        KeyCodeAlpha14.performed += ctx => { Debug.Log("Нажата клавиша 14"); OneHandred14.GetComponent<AudioSource>().Play(); GameManager.OneHandred14.GetComponent<AudioSource>().Stop();
            if (NameArtistA14.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA14.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA14.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA14.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA14.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA14.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA14.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA14.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA14.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA14.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA14.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA14.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA14.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA14.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA14.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA14.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA14.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA14.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA14.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA14.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA14.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA14.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA14.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA14.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA14.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA14.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA14.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA14.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA14.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA14.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA14.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA14.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA14.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA14.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA14.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA14.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA14.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA14.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA14.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA14.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA14.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA14.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA14.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA14.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA14.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA14.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA14.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA14.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA14.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA14.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA14.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA14.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA14.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA14.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA14.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA14.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA14.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA14.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA14.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA14.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA14.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA14.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha24.Enable();
        KeyCodeAlpha24.performed += ctx => { Debug.Log("Нажата клавиша 24"); OneHandred24.GetComponent<AudioSource>().Play(); GameManager.OneHandred24.GetComponent<AudioSource>().Stop();
            if (NameArtistA24.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA24.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA24.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA24.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA24.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA24.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA24.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA24.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA24.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA24.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA24.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA24.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA24.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA24.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA24.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA24.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA24.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA24.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA24.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA24.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA24.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA24.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA24.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA24.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA24.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA24.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA24.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA24.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA24.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA24.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA24.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA24.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA24.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA24.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA24.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA24.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA24.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA24.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA24.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA24.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA24.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA24.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA24.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA24.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA24.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA24.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA24.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA24.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA24.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA24.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA24.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA24.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA24.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA24.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA24.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA24.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA24.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA24.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA24.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA24.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA24.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA24.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha34.Enable();
        KeyCodeAlpha34.performed += ctx => { Debug.Log("Нажата клавиша 34"); OneHandred34.GetComponent<AudioSource>().Play(); GameManager.OneHandred34.GetComponent<AudioSource>().Stop();
            if (NameArtistA34.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA34.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA34.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA34.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA34.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA34.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA34.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA34.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA34.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA34.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA34.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA34.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA34.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA34.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA34.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA34.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA34.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA34.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA34.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA34.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA34.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA34.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA34.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA34.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA34.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA34.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA34.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA34.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA34.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA34.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA34.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA34.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA34.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA34.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA34.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA34.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA34.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA34.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA34.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA34.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA34.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA34.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA34.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA34.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA34.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA34.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA34.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA34.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA34.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA34.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA34.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA34.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA34.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA34.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA34.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA34.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA34.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA34.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA34.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA34.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA34.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA34.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha44.Enable();
        KeyCodeAlpha44.performed += ctx => { Debug.Log("Нажата клавиша 44"); OneHandred44.GetComponent<AudioSource>().Play(); GameManager.OneHandred44.GetComponent<AudioSource>().Stop();
            if (NameArtistA44.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA44.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA44.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA44.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA44.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA44.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA44.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA44.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA44.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA44.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA44.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA44.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA44.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA44.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA44.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA44.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA44.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA44.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA44.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA44.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA44.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA44.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA44.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA44.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA44.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA44.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA44.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA44.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA44.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA44.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA44.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA44.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA44.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA44.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA44.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA44.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA44.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA44.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA44.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA44.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA44.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA44.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA44.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA44.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA44.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA44.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA44.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA44.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA44.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA44.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA44.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA44.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA44.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA44.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA44.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA44.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA44.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA44.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA44.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA44.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA44.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA44.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };

        KeyCodeAlpha54.Enable();
        KeyCodeAlpha54.performed += ctx => { Debug.Log("Нажата клавиша 54"); OneHandred54.GetComponent<AudioSource>().Play(); GameManager.OneHandred54.GetComponent<AudioSource>().Stop();
            if (NameArtistA54.text == "Артур Пирожков")
            {
                HitBeatImage.sprite = ArturPerojkov.sprite;
            }
            if (NameArtistA54.text == "Инстасамка")
            {
                HitBeatImage.sprite = Instasamka.sprite;
            }
            if (NameArtistA54.text == "Отпетые мошенники")
            {
                HitBeatImage.sprite = OtpetieMosheiniki.sprite;
            }
            if (NameArtistA54.text == "Кино")
            {
                HitBeatImage.sprite = Kino.sprite;
            }
            if (NameArtistA54.text == "Гарик Сукачев")
            {
                HitBeatImage.sprite = Garik.sprite;
            }
            if (NameArtistA54.text == "Мэвл")
            {
                HitBeatImage.sprite = Mavl.sprite;
            }
            if (NameArtistA54.text == "ВИА гра")
            {
                HitBeatImage.sprite = ViaGra.sprite;
            }
            if (NameArtistA54.text == "Юлианна Караулова")
            {
                HitBeatImage.sprite = JuliannaKaraylova.sprite;
            }
            if (NameArtistA54.text == "Иванушки")
            {
                HitBeatImage.sprite = Ivanyski.sprite;
            }
            if (NameArtistA54.text == "Уматурман")
            {
                HitBeatImage.sprite = Ymatyrman.sprite;
            }
            if (NameArtistA54.text == "Олег Газманов")
            {
                HitBeatImage.sprite = OlegGazmanov.sprite;
            }
            if (NameArtistA54.text == "Градусы")
            {
                HitBeatImage.sprite = Gradysi.sprite;
            }
            if (NameArtistA54.text == "Мурат Насыров")
            {
                HitBeatImage.sprite = MyratNasirov.sprite;
            }
            if (NameArtistA54.text == "Камаз")
            {
                HitBeatImage.sprite = Kamazz.sprite;
            }
            if (NameArtistA54.text == "Рок Острова")
            {
                HitBeatImage.sprite = RokIsland.sprite;
            }
            if (NameArtistA54.text == "Дима Билан и Мари")
            {
                HitBeatImage.sprite = DimaBilanAndMari.sprite;
            }
            if (NameArtistA54.text == "Леонид Агутин и Владимир Пресняков")
            {
                HitBeatImage.sprite = LeonidAgutinAndVladimirPresnikov.sprite;
            }
            if (NameArtistA54.text == "Николай Басков и Таисися Повли")
            {
                HitBeatImage.sprite = NikolaiBaskovAndTaisiaPovali.sprite;
            }
            if (NameArtistA54.text == "Коста Лакоста и Серябкина")
            {
                HitBeatImage.sprite = KostaLakostaAndSerabkina.sprite;
            }
            if (NameArtistA54.text == "Артик и Асти и Джиган и Нилето")
            {
                HitBeatImage.sprite = DjiganNilettoArtickAsti.sprite;
            }
            if (NameArtistA54.text == "Татьяна Куртукова")
            {
                HitBeatImage.sprite = TatianaKyrtykova.sprite;
            }
            if (NameArtistA54.text == "Джаконе и Килиана")
            {
                HitBeatImage.sprite = JakoneAndKiliana.sprite;
            }
            if (NameArtistA54.text == "Бонд с кнопкой")
            {
                HitBeatImage.sprite = BondSKnipkoi.sprite;
            }
            if (NameArtistA54.text == "Годзила")
            {
                HitBeatImage.sprite = Godzilla.sprite;
            }
            if (NameArtistA54.text == "Леприконсы")
            {
                HitBeatImage.sprite = Leprikonsi.sprite;
            }
            if (NameArtistA54.text == "Майкл Джексон")
            {
                HitBeatImage.sprite = MichaelJackson.sprite;
            }
            if (NameArtistA54.text == "Кармен")
            {
                HitBeatImage.sprite = Karmen.sprite;
            }
            if (NameArtistA54.text == "Александр Серов")
            {
                HitBeatImage.sprite = AleksandSerov.sprite;
            }
            if (NameArtistA54.text == "Кулио")
            {
                HitBeatImage.sprite = Coolio.sprite;
            }
            if (NameArtistA54.text == "Жанна Фриске")
            {
                HitBeatImage.sprite = JannaFriske.sprite;
            }
            if (NameArtistA54.text == "Валентин Стрыкайло")
            {
                HitBeatImage.sprite = ValentinStrikalo.sprite;
            }
            if (NameArtistA54.text == "Баста и Максим")
            {
                HitBeatImage.sprite = BastaAndMaksim.sprite;
            }
            if (NameArtistA54.text == "Чили")
            {
                HitBeatImage.sprite = ChiLi.sprite;
            }
            if (NameArtistA54.text == "Хифи")
            {
                HitBeatImage.sprite = HiFi.sprite;
            }
            if (NameArtistA54.text == "Нирвана")
            {
                HitBeatImage.sprite = Nirvana.sprite;
            }
            if (NameArtistA54.text == "Алиса Веретено")
            {
                HitBeatImage.sprite = AlisaVereteno.sprite;
            }
            if (NameArtistA54.text == "Парк Горького")
            {
                HitBeatImage.sprite = ParkGorkovo.sprite;
            }
            if (NameArtistA54.text == "ACDC")
            {
                HitBeatImage.sprite = ACDC.sprite;
            }
            if (NameArtistA54.text == "Ирина Алегрова")
            {
                HitBeatImage.sprite = IrinaAlegrova.sprite;
            }
            if (NameArtistA54.text == "Мияги и Эндшпиль")
            {
                HitBeatImage.sprite = MyagiAndAndshpil.sprite;
            }
            if (NameArtistA54.text == "Зиверт")
            {
                HitBeatImage.sprite = Zivert.sprite;
            }
            if (NameArtistA54.text == "Юрий Лоза")
            {
                HitBeatImage.sprite = YriLoza.sprite;
            }
            if (NameArtistA54.text == "Звери")
            {
                HitBeatImage.sprite = Zveri.sprite;
            }
            if (NameArtistA54.text == "Баста")
            {
                HitBeatImage.sprite = Basta.sprite;
            }
            if (NameArtistA54.text == "Супер Жорик")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA54.text == "Мавик и Галибри")
            {
                HitBeatImage.sprite = SuperJprik.sprite;
            }
            if (NameArtistA54.text == "Ленинград")
            {
                HitBeatImage.sprite = Leningrad.sprite;
            }
            if (NameArtistA54.text == "Филипп Кирковров")
            {
                HitBeatImage.sprite = FelipKirkorov.sprite;
            }
            if (NameArtistA54.text == "Рики Мартин")
            {
                HitBeatImage.sprite = RickyMartin.sprite;
            }
            if (NameArtistA54.text == "Стас Михайлов")
            {
                HitBeatImage.sprite = StasMihailov.sprite;
            }
            if (NameArtistA54.text == "Пресли Элвис")
            {
                HitBeatImage.sprite = PresleyElvis.sprite;
            }
            if (NameArtistA54.text == "NSYNC")
            {
                HitBeatImage.sprite = NSYNC.sprite;
            }
            if (NameArtistA54.text == "Глаза Тигра")
            {
                HitBeatImage.sprite = EyeTiger.sprite;
            }
            if (NameArtistA54.text == "Уил Смит")
            {
                HitBeatImage.sprite = WillSmith.sprite;
            }
            if (NameArtistA54.text == "Карлес Виспер")
            {
                HitBeatImage.sprite = CarelessWhisper.sprite;
            }
            if (NameArtistA54.text == "Шрек")
            {
                HitBeatImage.sprite = Shrek.sprite;
            }
            if (NameArtistA54.text == "Канье Вест")
            {
                HitBeatImage.sprite = KanyeWest.sprite;
            }
            if (NameArtistA54.text == "Руки Вверх")
            {
                HitBeatImage.sprite = HandUp.sprite;
            }
            if (NameArtistA54.text == "БИС")
            {
                HitBeatImage.sprite = BIS.sprite;
            }
            if (NameArtistA54.text == "Браво")
            {
                HitBeatImage.sprite = Bravo.sprite;
            }
            if (NameArtistA54.text == "Михаил Мишустин")
            {
                HitBeatImage.sprite = MichailMishystin.sprite;
            }
            if (NameArtistA54.text == "АСтудия")
            {
                HitBeatImage.sprite = AStudio.sprite;
            }
        };
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