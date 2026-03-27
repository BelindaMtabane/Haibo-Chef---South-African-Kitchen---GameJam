# Haibo Chef! - South African Kitchen

A beginner-friendly Unity game prototype set in a South African kitchen.  
The final submission scope is gameplay-first, with no story/narrative or dialogue due to time limits.

---

## Project Overview
- **Title:** Haibo Chef! - South African Kitchen
- **Genre:** First-person cooking simulation with mini-game stations
- **Recipe Count:** 4 recipes
- **Main Goal:** Complete station tasks, improve food quality, and increase recognition text
- **Scope Note:** no dialogue and no narrative in this version
- **Flow State:** choose dishes -> complete sections -> plate -> quality evaluation -> recognition by boss chef

---

## Features
- Four kitchen systems:
  - `Cutting`
  - `Stirring`
  - `Cooking`
  - `Plating`
- Inventory allocation by ingredient categories:
  - `Meats`, `Vegetables`, `DryIngredients`, `WetIngredients`, `Spices`
- `Cutting` uses a color-matching game
- `Stirring` is a breather runner food-run where player collects apples and reaches the end of a running trail
- `Cooking` requires pressing the action button until progress reaches `100%` (then object disappears)
- `Plating` shows food quality and increases recognition text
- Runner health mechanic (`100` base health, `-20%` for each incorrect ingredient)
- Runner obstacle pressure (rocks/stones slow the player or cost time)
- Runner objective is survival + completion, then return to kitchen cooking flow
- Tools menu with custom game artwork and 3 selectable background music tracks

---

## Controls (Default)
> These are starter controls and can be changed in Unity input settings.

### Global
- `WASD` - Move
- `Mouse` - Look
- `E` - Interact / use station
- `Esc` - Pause / back

### Cutting
- `E` to start station
- Complete color game inputs

### Stirring
- `E` to start station
- Complete runner trail, collect apples, avoid obstacles, and reach the end goal

### Cooking
- Press the action/game button until process reaches `100%`
- Cooking object disappears when complete

### Plating
- `E` to plate final dish
- Final quality and recognition text are shown and updated

### Runner (Super Market)
- `A/D` (or lane movement keys) to navigate
- Collect apples and avoid obstacle collisions
- Incorrect ingredient collection reduces health by 20% from a starting 100
- Obstacles (rocks/stones) reduce speed or effective time
- Runner arena spawn test uses:
  - `x`: `233.72` to `253.94`
  - `z`: `-50.36` to `47.9`
  - `y`: `50.2`

### Tools Menu
- A tools/settings menu can be opened to view game artwork and manage music
- Includes 3 background music options from Artlist.io (new clips added)
- Includes a stop music option

---

## Tools Menu Setup (Unity)
1. Add `ToolsMenuController` to a UI manager object.
2. Assign:
   - `Tools Panel` (menu root panel)
   - `Menu Artwork` (UI Image)
   - `Title Image` (imported title artwork)
   - `Now Playing Text` (TMP text)
   - `Music Source` (AudioSource)
   - `Track 1`, `Track 2`, `Track 3` (Artlist.io audio clips)
3. Hook button `OnClick` events to:
   - `OpenToolsMenu()`
   - `CloseToolsMenu()`
   - `PlayTrack1()`, `PlayTrack2()`, `PlayTrack3()`
   - `StopMusic()`

---

## Development Credentials / Tools
- **Unity 2022 LTS** (C# project)
- **GitHub Copilot**
- **Cursor IDE**
- **ChatGPT**
- **Mixamo**
- **Artlist.io** (3 background music tracks)
- **AI art tools** (asset support)
- **AI documentation tools** (writing/restructure support)

---

## AI Tool Usage (Expanded)
### GitHub Copilot
- Assisted with script suggestions and quick implementation iterations

### ChatGPT
- Helped break down project documentation and planning structure
- Assisted with implementation phrasing and feature summaries

### Cursor
- Assisted with script scaffolding and organization
- Helped improve structure/readability during iteration

### Mixamo
- Provided animation support for character/gameplay presentation

### AI Art/Docs Tools
- Assisted with generated art placeholders and documentation drafting

### AI Usage Notes
- AI outputs were reviewed and adapted before use
- The game keeps a respectful South African cultural framing
- Scope kept student-friendly to avoid over-engineering

---

## AI Ethics Statement
- AI was used as a support tool for ideation, drafting, and structure, not as a replacement for developer decision-making.
- Original game direction, feature choices, tuning, and final implementation decisions remain human-authored.
- All AI-assisted outputs were reviewed, edited, and tested before inclusion.
- The project avoids copying copyrighted content and does not claim ownership over third-party or generated material that requires attribution.
- Cultural references are handled with care to keep the South African theme respectful and non-stereotypical.
- This README openly documents AI usage to maintain transparency in the development process.

---

## Installation / Run Instructions

### Requirements
- Unity Hub
- Unity Editor **2022 LTS**
- Windows PC target

### Run in Unity Editor
1. Clone or download this repository.
2. Open **Unity Hub**.
3. Click **Add project from disk** and select this project folder.
4. Open the main game scene in `Assets/Scenes/`.
5. Press **Play** in the Unity Editor.

### Build for Windows (Optional)
1. Open `File -> Build Settings`.
2. Select `PC, Mac & Linux Standalone` and target Windows.
3. Click `Build` or `Build And Run`.

---

## Notes
- This project is a student prototype focused on clarity and fun.
- Some milestone polish goals were not fully completed; gameplay is still engaging and demonstrable.
- There are known build issues in the current version.
- A gameplay video is provided to demonstrate completed systems.
- The game is not time-based in this final submission version.
- Main menu return and exit flow were added to improve usability.
- See `plan.md` for milestones and scope details.
- See `refinements-changes.md` for running development changes.
