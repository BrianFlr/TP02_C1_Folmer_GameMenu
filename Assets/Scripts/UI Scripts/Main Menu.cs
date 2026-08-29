using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private Button btnStart;
    [SerializeField] private Button btnSettings;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnExit;

    private void Awake()
    {
        btnStart.onClick.AddListener(OnStartClicked);
        btnSettings.onClick.AddListener(OnSettingsClicked);
        btnCredits.onClick.AddListener(OnCreditsClicked);
        btnExit.onClick.AddListener(OnExitClicked);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // Custom Functions
    private void OnDestroy()
    {
        btnStart.onClick.RemoveAllListeners();
        btnSettings.onClick.RemoveAllListeners();
        btnCredits.onClick.RemoveAllListeners();
        btnExit.onClick.RemoveAllListeners();
    }

    private void OnStartClicked()
    {

    }
    private void OnSettingsClicked()
    {

    }
    private void OnCreditsClicked()
    {

    }
    private void OnExitClicked()
    {

    }
}
