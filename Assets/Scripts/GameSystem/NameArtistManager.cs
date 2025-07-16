using TMPro;
using UnityEngine;

public class NameArtistManager : MonoBehaviour
{
    public TMP_InputField NameArtist11;
    public TMP_InputField NameArtist21;
    public TMP_InputField NameArtist31;
    public TMP_InputField NameArtist41;
    public TMP_InputField NameArtist51;

    public TMP_InputField NameArtist12;
    public TMP_InputField NameArtist22;
    public TMP_InputField NameArtist32;
    public TMP_InputField NameArtist42;
    public TMP_InputField NameArtist52;

    public TMP_InputField NameArtist13;
    public TMP_InputField NameArtist23;
    public TMP_InputField NameArtist33;
    public TMP_InputField NameArtist43;
    public TMP_InputField NameArtist53;

    public TMP_InputField NameArtist14;
    public TMP_InputField NameArtist24;
    public TMP_InputField NameArtist34;
    public TMP_InputField NameArtist44;
    public TMP_InputField NameArtist54;

    private void Update()
    { 
        GameManagerAnswer.NameArtistA11 = NameArtist11;
        GameManagerAnswer.NameArtistA21 = NameArtist21;
        GameManagerAnswer.NameArtistA31 = NameArtist31;
        GameManagerAnswer.NameArtistA41 = NameArtist41;
        GameManagerAnswer.NameArtistA51 = NameArtist51;

        GameManagerAnswer.NameArtistA12 = NameArtist12;
        GameManagerAnswer.NameArtistA22 = NameArtist22;
        GameManagerAnswer.NameArtistA32 = NameArtist32;
        GameManagerAnswer.NameArtistA42 = NameArtist42;
        GameManagerAnswer.NameArtistA52 = NameArtist52;

        GameManagerAnswer.NameArtistA13 = NameArtist13;
        GameManagerAnswer.NameArtistA23 = NameArtist23;
        GameManagerAnswer.NameArtistA33 = NameArtist33;
        GameManagerAnswer.NameArtistA43 = NameArtist43;
        GameManagerAnswer.NameArtistA53 = NameArtist53;

        GameManagerAnswer.NameArtistA14 = NameArtist14;
        GameManagerAnswer.NameArtistA24 = NameArtist24;
        GameManagerAnswer.NameArtistA34 = NameArtist34;
        GameManagerAnswer.NameArtistA44 = NameArtist44;
        GameManagerAnswer.NameArtistA54 = NameArtist54;
    }
}
