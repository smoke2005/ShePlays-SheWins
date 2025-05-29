using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit; // Include XR Toolkit namespace

public class PotionInteract : XRGrabInteractable
{
    // Reference to the cauldron puzzle script
    public CauldronPuzzle cauldron;

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        
        // Place potion in the cauldron when released
        cauldron.PlacePotion(gameObject);
        
        // Optionally hide or disable potion after placing
        gameObject.SetActive(false);
    }
}