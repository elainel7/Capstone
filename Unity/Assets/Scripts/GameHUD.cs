using UnityEngine;
using UnityEngine.UI;

public class GameHUD : MonoBehaviour
{
    [Header("Optional: assign to use existing UI")]
    [SerializeField] private Text timeText;
    [SerializeField] private Text coinsText;

    [Header("Auto-create settings (used if references above are empty)")]
    [SerializeField] private int fontSize = 24;
    [SerializeField] private Color textColor = Color.white;

    private void Start()
    {
        if (timeText == null || coinsText == null)
            CreateRuntimeUI();
    }

    private void CreateRuntimeUI()
    {
        var canvasObj = new GameObject("HUD Canvas");
        var canvas = canvasObj.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvasObj.AddComponent<CanvasScaler>().uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        canvasObj.AddComponent<GraphicRaycaster>();

        var timeObj = new GameObject("TimeText");
        timeObj.transform.SetParent(canvasObj.transform, false);
        timeText = timeObj.AddComponent<Text>();
        timeText.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        timeText.fontSize = fontSize;
        timeText.color = textColor;
        timeText.alignment = TextAnchor.UpperLeft;
        var timeRect = timeObj.GetComponent<RectTransform>();
        timeRect.anchorMin = new Vector2(0.02f, 0.92f);
        timeRect.anchorMax = new Vector2(0.3f, 1f);
        timeRect.offsetMin = Vector2.zero;
        timeRect.offsetMax = Vector2.zero;

        var coinsObj = new GameObject("CoinsText");
        coinsObj.transform.SetParent(canvasObj.transform, false);
        coinsText = coinsObj.AddComponent<Text>();
        coinsText.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        coinsText.fontSize = fontSize;
        coinsText.color = textColor;
        coinsText.alignment = TextAnchor.UpperLeft;
        var coinsRect = coinsObj.GetComponent<RectTransform>();
        coinsRect.anchorMin = new Vector2(0.02f, 0.84f);
        coinsRect.anchorMax = new Vector2(0.3f, 0.92f);
        coinsRect.offsetMin = Vector2.zero;
        coinsRect.offsetMax = Vector2.zero;

    }

    private void Update()
    {
        if (GameManager.Instance == null) return;
        if (timeText != null) timeText.text = FormatTime(GameManager.Instance.ElapsedTime);
        if (coinsText != null) coinsText.text = $"x {GameManager.Instance.coins:D2}";
    }

    private static string FormatTime(float seconds)
    {
        int total = Mathf.FloorToInt(seconds);
        int mins = total / 60;
        int secs = total % 60;
        return $"{mins}:{secs:D2}";
    }
}
