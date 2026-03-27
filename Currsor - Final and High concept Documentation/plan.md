# Haibo Chef! - Unity Project Plan

## Project Overview
**Haibo Chef! - South African Kitchen** is a first-person cooking simulation prototype.  
The final student scope is gameplay-first: no story/narrative and no dialogue due to limited time.

## Core Systems
- Kitchen sections: `Cutting`, `Stirring`, `Cooking`, `Plating`
- Inventory categories: `Meats`, `Vegetables`, `DryIngredients`, `WetIngredients`, `Spices`
- Fixed recipe count: `4` recipes
- `Cutting`: color-based mini game
- `Stirring`: breather runner section where player collects apples and reaches end of running trail
- `Cooking`: press action button until process reaches `100%`, then cooking object disappears
- `Plating`: show quality result and increase recognition text
- Runner health system: starts at `100`, incorrect ingredients reduce health by `20%`
- Runner obstacles (rocks/stones) that slow the player or cost time
- Tools menu with title artwork and 3 music track options

## Core Gameplay Loop
1. Select one of the four recipes
2. Complete `Cutting` color game
3. Complete `Stirring` runner trail section (collect apples + avoid obstacles)
4. Complete `Cooking` button press process to `100%`
5. Complete `Plating` and read quality + recognition text

## Milestones

### Daily Sprint (Primary)
#### Day 1 - Foundation
- Set up scene layout and station interaction points
- Implement basic flow state: `Cutting -> Stirring -> Cooking -> Plating`
- Add station prompts and basic gameplay guidance

#### Day 2 - Systems
- Add inventory data and per-station ingredient requirements
- Implement runner food-run path, pickups, and obstacle behavior
- Implement health feedback in runner section (non-time-based loop)

#### Day 3 - Final Integration
- Implement cooking progress mechanic to `100%`
- Add plating quality and recognition text output
- Add flow usability: return to main menu and exit options
- Run smoke tests and fix critical blockers
- Record gameplay video for demonstration due build issues

### Weekly Extension (Optional)
#### Week 1
- Add more recipes and station variation
- Improve UI clarity and icon consistency

#### Week 2
- Polish feel/fun factor and improve pacing
- Add simple save for recognition progress

## Priority Breakdown

### UI
- Main menu + settings
- Kitchen HUD (step, inventory, quality, recognition)
- Station prompts and objective alerts
- Runner UI (health and trail objective prompts)
- End-of-dish feedback panel

### Gameplay Systems
- State machine for dish progression
- Inventory checks and consumption rules
- Runner end-trail objective logic
- Runner obstacle + health penalty logic
- Cooking progress to `100%` and completion cleanup
- Recognition text progression

### Audio
- Runner hit/slow obstacle cues
- UI click sounds
- Basic cooking/plating feedback sounds

### Testing
- Full dish run without soft-locks
- Inventory correctness checks
- Runner health behavior checks
- Runner obstacle slowdown and 20% health penalty checks
- Cooking process reaches 100% and clears correctly
- Flow check: dish selection -> stations -> plating evaluation -> recognition text

### Polishing
- UI readability and pacing
- Feedback clarity after each dish
- Improve engagement; note that full polish scope was not completed

## AI Tools Used
- **GitHub Copilot**: code suggestions and quick iteration in scripts
- **ChatGPT**: breakdown of documentation and planning support
- **Cursor**: code edits, structure updates, and project refinement
- **Mixamo**: animation support for character/gameplay presentation
- **Artlist.io**: 3 background music tracks for a fun gameplay tone
- **AI art tools**: generated placeholder art assets where needed
- **AI documentation support**: assisted with writing and restructuring docs

## Deliverable Target
A playable student-friendly prototype with four recipes and complete station flow.
Known limitation: there are unresolved build issues, so a gameplay video is included to demonstrate implemented work.

## Reflection
- Some milestones were not polished to a high fun-factor level, but the gameplay loop is engaging and functional.
- Main challenges included misleading AI suggestions, execution errors, syntax misunderstandings, and a partially broken Unity setup.
- Despite these issues, documentation was adjusted, a build was produced, and gameplay videos were prepared in time for submission.
