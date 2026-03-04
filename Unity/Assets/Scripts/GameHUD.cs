using UnityEngine;
using UnityEngine.UI;

public class GameHUD : MonoBehaviour
{
    [Header("Optional: assign to use existing UI")]
    [SerializeField] private Text timeText;
    [SerializeField] private Text levelCoinsText;

    [Header("Auto-create settings (used if references above are empty)")]
    [SerializeField] private int fontSize = 24;
    [SerializeField] private Color textColor = Color.white;

    private void Start()
    {
        if (timeText == null || levelCoinsText == null)
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

        var levelCoinsObj = new GameObject("LevelCoinsText");
        levelCoinsObj.transform.SetParent(canvasObj.transform, false);
        levelCoinsText = levelCoinsObj.AddComponent<Text>();
        levelCoinsText.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        levelCoinsText.fontSize = fontSize;
        levelCoinsText.color = textColor;
        levelCoinsText.alignment = TextAnchor.UpperLeft;
        var levelCoinsRect = levelCoinsObj.GetComponent<RectTransform>();
        levelCoinsRect.anchorMin = new Vector2(0.02f, 0.84f);
        levelCoinsRect.anchorMax = new Vector2(0.3f, 0.92f);
        levelCoinsRect.offsetMin = Vector2.zero;
        levelCoinsRect.offsetMax = Vector2.zero;
    }

    private void Update()
    {
        if (GameManager.Instance == null) return;
        if (timeText != null) timeText.text = FormatTime(GameManager.Instance.ElapsedTime);
        if (levelCoinsText != null) levelCoinsText.text = $"Coins: {GameManager.Instance.levelCoinsCollected}/{GameManager.Instance.levelCoinsTotal}";
    }

    private static string FormatTime(float seconds)
    {
        int total = Mathf.FloorToInt(seconds);
        int mins = total / 60;
        int secs = total % 60;
        return $"{mins}:{secs:D2}";
    }
}
