using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class FetchLogo : MonoBehaviour
{
    IEnumerator Start()
    {
        string url =
            "https://upload.wikimedia.org/wikipedia/commons/3/3e/Einstein_1921_by_F_Schmutzer_-_restoration.jpg";
        var request = UnityWebRequestTexture.GetTexture(url);

        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("Succeeded");
            var textureHandler = request.downloadHandler as DownloadHandlerTexture;
            Texture2D texture = textureHandler.texture;

            var spriteRenderer = GetComponent<SpriteRenderer>();
            var rect = new Rect(0, 0, texture.width, texture.height);
            spriteRenderer.sprite = Sprite.Create(texture, rect, Vector2.zero);
        }
        else
        {
            Debug.Log("Failed");
            Debug.Log(request.error);
        }
    }
}