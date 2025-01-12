using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _plantedText.SetText("Seeds Planted: " + seedsPlanted);
        _remainingText.SetText("Seeds Remaining: " + seedsLeft);
        seedsLeft--;
        seedsPlanted++;
    }
}