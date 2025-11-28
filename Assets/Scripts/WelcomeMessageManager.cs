using UnityEngine;
using TMPro;

public class WelcomeMessageManager : MonoBehaviour
{
    public TMP_Text welcomeText; // Gán trong Inspector
    public PlayerData playerData; // Gán ScriptableObject chứa tên người chơi

    void Start()
    {
        string playerName = playerData.characterName;
        if (string.IsNullOrEmpty(playerName))
        {
            playerName = "bạn"; // fallback nếu tên rỗng
        }

        welcomeText.text = $"Chào {playerName}! Chào mừng đến với Eldoria Valley! - nơi thời gian như ngừng trôi, và những hạt giống cũ vẫn còn chờ ngày nảy mầm.\n" +
            $"Người ông quá cố đã để lại cho bạn một nông trại hoang tàn, cùng những bí mật chưa từng hé lộ.\n" +
            $"Hãy đến gặp thị trưởng để bắt đầu cuộc sống mới của bạn.";
    }
}
