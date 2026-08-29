using UnityEngine;
using UnityEngine.UI;

public class CreditsMenu : MonoBehaviour
{
    [Header("Canvas")]
    [SerializeField] private GameObject creditsCanvas;

    [Header("Buttons")]
    [SerializeField] private Button btnBack;

    private void Awake()
    {
        btnBack.onClick.AddListener(OnBackClicked);
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnDestroy()
    {
        btnBack.onClick.RemoveAllListeners();
    }

    // Custom Functions
    private void OnBackClicked()
    {

    }
}
