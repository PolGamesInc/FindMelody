using SFB;
using UnityEngine;
using System.Collections;

public class AudioLoader : MonoBehaviour
{
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;
    public AudioSource audioSource5;

    public AudioSource audioSource12;
    public AudioSource audioSource22;
    public AudioSource audioSource32;
    public AudioSource audioSource42;
    public AudioSource audioSource52;

    public AudioSource audioSource13;
    public AudioSource audioSource23;
    public AudioSource audioSource33;
    public AudioSource audioSource43;
    public AudioSource audioSource53;

    public AudioSource audioSource14;
    public AudioSource audioSource24;
    public AudioSource audioSource34;
    public AudioSource audioSource44;
    public AudioSource audioSource54;

    // static переменная для хранения AudioClip
    public static AudioClip NewSelectedAudioClip1;
    public static AudioClip NewSelectedAudioClip2;
    public static AudioClip NewSelectedAudioClip3;
    public static AudioClip NewSelectedAudioClip4;
    public static AudioClip NewSelectedAudioClip5;

    public static AudioClip NewSelectedAudioClip12;
    public static AudioClip NewSelectedAudioClip22;
    public static AudioClip NewSelectedAudioClip32;
    public static AudioClip NewSelectedAudioClip42;
    public static AudioClip NewSelectedAudioClip52;

    public static AudioClip NewSelectedAudioClip13;
    public static AudioClip NewSelectedAudioClip23;
    public static AudioClip NewSelectedAudioClip33;
    public static AudioClip NewSelectedAudioClip43;
    public static AudioClip NewSelectedAudioClip53;

    public static AudioClip NewSelectedAudioClip14;
    public static AudioClip NewSelectedAudioClip24;
    public static AudioClip NewSelectedAudioClip34;
    public static AudioClip NewSelectedAudioClip44;
    public static AudioClip NewSelectedAudioClip54;

    public void OnLoadButtonClicked1()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio1(paths[0]));
        }
    }

    public void OnLoadButtonClicked2()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio2(paths[0]));
        }
    }

    public void OnLoadButtonClicked3()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio3(paths[0]));
        }
    }

    public void OnLoadButtonClicked4()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio4(paths[0]));
        }
    }

    public void OnLoadButtonClicked5()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio5(paths[0]));
        }
    }

    public void OnLoadButtonClicked12()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio12(paths[0]));
        }
    }

    public void OnLoadButtonClicked22()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio22(paths[0]));
        }
    }

    public void OnLoadButtonClicked32()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio32(paths[0]));
        }
    }

    public void OnLoadButtonClicked42()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio42(paths[0]));
        }
    }
    public void OnLoadButtonClicked52()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio52(paths[0]));
        }
    }

    public void OnLoadButtonClicked13()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio13(paths[0]));
        }
    }

    public void OnLoadButtonClicked23()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio23(paths[0]));
        }
    }

    public void OnLoadButtonClicked33()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio33(paths[0]));
        }
    }

    public void OnLoadButtonClicked43()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio43(paths[0]));
        }
    }
    public void OnLoadButtonClicked53()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio5(paths[0]));
        }
    }

    public void OnLoadButtonClicked14()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio14(paths[0]));
        }
    }

    public void OnLoadButtonClicked24()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio24(paths[0]));
        }
    }

    public void OnLoadButtonClicked34()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio34(paths[0]));
        }
    }

    public void OnLoadButtonClicked44()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio44(paths[0]));
        }
    }
    public void OnLoadButtonClicked54()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio54(paths[0]));
        }
    }


    IEnumerator LoadAudio1(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip1 = clip;              // записываем в static переменную
                audioSource1.clip = NewSelectedAudioClip1;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio2(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip2 = clip;
                audioSource2.clip = NewSelectedAudioClip2;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio3(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip3 = clip;
                audioSource3.clip = NewSelectedAudioClip3;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio4(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip4 = clip;
                audioSource4.clip = NewSelectedAudioClip4;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio5(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip5 = clip;
                audioSource5.clip = NewSelectedAudioClip5;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio12(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip12 = clip;
                audioSource12.clip = NewSelectedAudioClip12;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio22(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip22 = clip;
                audioSource22.clip = NewSelectedAudioClip22;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio32(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip32 = clip;
                audioSource32.clip = NewSelectedAudioClip32;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio42(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip42 = clip;
                audioSource42.clip = NewSelectedAudioClip42;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio52(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip52 = clip;
                audioSource52.clip = NewSelectedAudioClip52;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio13(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip13 = clip;
                audioSource13.clip = NewSelectedAudioClip13;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio23(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip23 = clip;
                audioSource23.clip = NewSelectedAudioClip23;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio33(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip33 = clip;
                audioSource33.clip = NewSelectedAudioClip33;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio43(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip43 = clip;
                audioSource43.clip = NewSelectedAudioClip43;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio53(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip53 = clip;
                audioSource53.clip = NewSelectedAudioClip53;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio14(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip14 = clip;
                audioSource14.clip = NewSelectedAudioClip14;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio24(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip24 = clip;
                audioSource24.clip = NewSelectedAudioClip24;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio34(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip34 = clip;
                audioSource34.clip = NewSelectedAudioClip34;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio44(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip44 = clip;
                audioSource44.clip = NewSelectedAudioClip44;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio54(string path)
    {
        string url = "file:///" + path;

        using (var www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                AudioClip clip = www.GetAudioClip(false, false);
                while (clip.loadState != AudioDataLoadState.Loaded)
                    yield return null;

                NewSelectedAudioClip54 = clip;
                audioSource54.clip = NewSelectedAudioClip54;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }
}

