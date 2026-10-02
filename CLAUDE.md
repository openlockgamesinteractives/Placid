# Placid

Unreal Engine **5.8** C++ project, started from the **Third Person** template (with all three template variants: Combat, Platforming, SideScrolling).

## The game

- **Genre:** psychological crime thriller.
- **Protagonist:** Vincent Langley, a mentalist detective.
- **Setting:** Greyford, a rainy city.
- **Camera plan:**
  - Exploration → third-person
  - Stealth and interrogations → first-person
  - Cutscenes → third-person (cinematic)

## Layout

- `Placid.uproject`: project descriptor. One runtime module, `Placid`. Plugins: StateTree, GameplayStateTree, ModelingToolsEditorMode.
- `Source/Placid/`: the single C++ game module.
  - `PlacidCharacter`, `PlacidGameMode`, `PlacidPlayerController`: base third-person template classes (spring-arm follow camera, Enhanced Input move/look/jump).
  - `Variant_Combat/`, `Variant_Platforming/`, `Variant_SideScrolling/`: template sample gameplay (AI, anim notifies, UI). It's reference material, not Placid gameplay, and will likely be removed or replaced eventually.
  - `Placid.Build.cs`: module deps (EnhancedInput, AIModule, StateTree, UMG, Slate) and include paths for each variant folder. **If a variant folder is deleted, remove its include paths here too.**
- `Source/Placid.Target.cs`, `Source/PlacidEditor.Target.cs`: build targets.
- `Config/`: `Default*.ini`. Startup map and default game mode are `/Game/ThirdPerson/Lvl_ThirdPerson` and `BP_ThirdPersonGameMode`.
- `Content/`: assets (`.uasset`/`.umap`, stored in Git LFS). `ThirdPerson/`, `Characters/Mannequins/`, `Input/` (IMC_Default, IMC_MouseLook), `LevelPrototyping/`, plus a `Variant_*` folder for each variant. `__ExternalActors__`/`__ExternalObjects__` are One File Per Actor data and must be committed.
- Generated, not committed: `Binaries/`, `Intermediate/`, `Saved/`, `DerivedDataCache/`, `.vs/`, `*.sln`/`*.slnx`, `Backup/`, `UpgradeLog.htm`. Regenerate the solution via right-click `Placid.uproject` → *Generate Visual Studio project files*.

## Conventions

- Platform: Windows, Visual Studio. The code follows Epic's style: `A`/`U`/`F`/`I`/`E` prefixes, `UPROPERTY`/`UFUNCTION` reflection, tabs.
- Template classes split input handling (`Move`/`Look`) from `BlueprintCallable` `DoMove`/`DoLook`/`DoJump*` so UI/touch can drive them. New code should follow that pattern.
- Version control: Git + Git LFS (see `.gitattributes`). Binary assets aren't mergeable, so coordinate edits to `.uasset`/`.umap` files.
- Don't edit gameplay code unless the task asks for it.
