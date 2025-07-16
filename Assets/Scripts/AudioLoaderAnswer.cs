using SFB;
using UnityEngine;
using System.Collections;

public class AudioLoaderAnswer : MonoBehaviour
{
    public AudioSource audioSource1A;
    public AudioSource audioSource2A;
    public AudioSource audioSource3A;
    public AudioSource audioSource4A;
    public AudioSource audioSource5A;

    public AudioSource audioSource12A;
    public AudioSource audioSource22A;
    public AudioSource audioSource32A;
    public AudioSource audioSource42A;
    public AudioSource audioSource52A;

    public AudioSource audioSource13A;
    public AudioSource audioSource23A;
    public AudioSource audioSource33A;
    public AudioSource audioSource43A;
    public AudioSource audioSource53A;

    public AudioSource audioSource14A;
    public AudioSource audioSource24A;
    public AudioSource audioSource34A;
    public AudioSource audioSource44A;
    public AudioSource audioSource54A;

    // static переменная для хранения AudioClip
    public static AudioClip NewSelectedAudioClip1A;
    public static AudioClip NewSelectedAudioClip2A;
    public static AudioClip NewSelectedAudioClip3A;
    public static AudioClip NewSelectedAudioClip4A;
    public static AudioClip NewSelectedAudioClip5A;

    public static AudioClip NewSelectedAudioClip12A;
    public static AudioClip NewSelectedAudioClip22A;
    public static AudioClip NewSelectedAudioClip32A;
    public static AudioClip NewSelectedAudioClip42A;
    public static AudioClip NewSelectedAudioClip52A;

    public static AudioClip NewSelectedAudioClip13A;
    public static AudioClip NewSelectedAudioClip23A;
    public static AudioClip NewSelectedAudioClip33A;
    public static AudioClip NewSelectedAudioClip43A;
    public static AudioClip NewSelectedAudioClip53A;

    public static AudioClip NewSelectedAudioClip14A;
    public static AudioClip NewSelectedAudioClip24A;
    public static AudioClip NewSelectedAudioClip34A;
    public static AudioClip NewSelectedAudioClip44A;
    public static AudioClip NewSelectedAudioClip54A;

    public void OnLoadButtonClicked1A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio1A(paths[0]));
        }
    }

    public void OnLoadButtonClicked2A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio2A(paths[0]));
        }
    }

    public void OnLoadButtonClicked3A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio3A(paths[0]));
        }
    }

    public void OnLoadButtonClicked4A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio4A(paths[0]));
        }
    }

    public void OnLoadButtonClicked5A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio5A(paths[0]));
        }
    }

    public void OnLoadButtonClicked12A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio12A(paths[0]));
        }
    }

    public void OnLoadButtonClicked22A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio22A(paths[0]));
        }
    }

    public void OnLoadButtonClicked32A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio32A(paths[0]));
        }
    }

    public void OnLoadButtonClicked42A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio42A(paths[0]));
        }
    }
    public void OnLoadButtonClicked52A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio52A(paths[0]));
        }
    }

    public void OnLoadButtonClicked13A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio13A(paths[0]));
        }
    }

    public void OnLoadButtonClicked23A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio23A(paths[0]));
        }
    }

    public void OnLoadButtonClicked33A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio33A(paths[0]));
        }
    }

    public void OnLoadButtonClicked43A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio43A(paths[0]));
        }
    }
    public void OnLoadButtonClicked53A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio53A(paths[0]));
        }
    }

    public void OnLoadButtonClicked14A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio14A(paths[0]));
        }
    }

    public void OnLoadButtonClicked24A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio24A(paths[0]));
        }
    }

    public void OnLoadButtonClicked34A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio34A(paths[0]));
        }
    }

    public void OnLoadButtonClicked44A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio44A(paths[0]));
        }
    }
    public void OnLoadButtonClicked54A()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select MP3 file", "", "mp3", false);
        if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0]))
        {
            StartCoroutine(LoadAudio54A(paths[0]));
        }
    }


    IEnumerator LoadAudio1A(string path)
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

                NewSelectedAudioClip1A = clip;              // записываем в static переменную
                audioSource1A.clip = NewSelectedAudioClip1A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio2A(string path)
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

                NewSelectedAudioClip2A = clip;
                audioSource2A.clip = NewSelectedAudioClip2A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio3A(string path)
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

                NewSelectedAudioClip3A = clip;
                audioSource3A.clip = NewSelectedAudioClip3A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio4A(string path)
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

                NewSelectedAudioClip4A = clip;
                audioSource4A.clip = NewSelectedAudioClip4A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio5A(string path)
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

                NewSelectedAudioClip5A = clip;
                audioSource5A.clip = NewSelectedAudioClip5A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio12A(string path)
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

                NewSelectedAudioClip12A = clip;
                audioSource12A.clip = NewSelectedAudioClip12A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio22A(string path)
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

                NewSelectedAudioClip22A = clip;
                audioSource22A.clip = NewSelectedAudioClip22A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio32A(string path)
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

                NewSelectedAudioClip32A = clip;
                audioSource32A.clip = NewSelectedAudioClip32A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio42A(string path)
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

                NewSelectedAudioClip42A = clip;
                audioSource42A.clip = NewSelectedAudioClip42A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio52A(string path)
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

                NewSelectedAudioClip52A = clip;
                audioSource52A.clip = NewSelectedAudioClip52A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio13A(string path)
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

                NewSelectedAudioClip13A = clip;
                audioSource13A.clip = NewSelectedAudioClip13A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio23A(string path)
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

                NewSelectedAudioClip23A = clip;
                audioSource23A.clip = NewSelectedAudioClip23A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio33A(string path)
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

                NewSelectedAudioClip33A = clip;
                audioSource33A.clip = NewSelectedAudioClip33A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio43A(string path)
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

                NewSelectedAudioClip43A = clip;
                audioSource43A.clip = NewSelectedAudioClip43A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio53A(string path)
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

                NewSelectedAudioClip53A = clip;
                audioSource53A.clip = NewSelectedAudioClip53A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio14A(string path)
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

                NewSelectedAudioClip14A = clip;
                audioSource14A.clip = NewSelectedAudioClip14A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio24A(string path)
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

                NewSelectedAudioClip24A = clip;
                audioSource24A.clip = NewSelectedAudioClip24A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio34A(string path)
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

                NewSelectedAudioClip34A = clip;
                audioSource34A.clip = NewSelectedAudioClip34A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio44A(string path)
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

                NewSelectedAudioClip44A = clip;
                audioSource44A.clip = NewSelectedAudioClip44A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }

    IEnumerator LoadAudio54A(string path)
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

                NewSelectedAudioClip54A = clip;
                audioSource54A.clip = NewSelectedAudioClip54A;
            }
            else
            {
                Debug.LogError("Ошибка загрузки аудио: " + www.error);
            }
        }
    }
}
