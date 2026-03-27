# refinements-changes.md Development Log (running log)

This file tracks meaningful design and implementation refinements for **Haibo Chef! - South African Kitchen**.

---

## 2026-03-24
**Date:** 2026-03-24  
**Change:** Initial game concept and core systems were defined.
- Finalized title and pitch direction: **Haibo Chef! - South African Kitchen**
- Set the game as a first-person cooking simulation with rhythm-supported gameplay
- Defined the primary kitchen interactive sections:
  - `Cutting`
  - `Stirring`
  - `Cooking`
  - `Plating`
- Established the core gameplay loop:
  - Orders -> Preparation -> Execution -> Serve -> Analysis/Improvement
- Added a lightweight causal clicker concept to keep interactions simple and responsive
- Added onboarding storyboard intent for player introduction:
  - Main Chef introduction
  - Assistant Chef/player introduction before station selection

**Reason:**  
The project needed a focused foundation that is realistic for a student prototype while still feeling engaging and culturally distinct.

**Improvements Made:**  
- Improved project clarity by locking the core loop early
- Reduced design ambiguity between rhythm mechanics and cooking mechanics
- Created a stable baseline for future balancing and UI planning

---

## 2026-03-25
**Date:** 2026-03-25  
**Change:** South African theme direction and a 3-minute Runner restock flow were introduced/refined.
- Expanded theme direction for a vibrant, cartoon-stylized South African kitchen atmosphere
- Refined dialogue style goals for a respectful and energetic local tone
- Updated the restock segment to a short Runner mini game in a super market/open market scene:
  - Set a 3-minute runner duration for restock pressure
  - Added realistic obstacles (rocks/stones) that slow the player or cost time
  - Added random altar/object spawn space for testing in the market scene
- Added Runner mini game health logic:
  - Introduced a runner `Health` value
  - Collecting incorrect ingredients decreases health by 20% (from 100)
  - Health is displayed in the runner UI
  - Health and time both act as pressure mechanics during restocking

**Reason:**  
The game required stronger identity and clearer gameplay stakes during ingredient restocking to support tension and strategy.

**Improvements Made:**  
- Strengthened thematic identity and player immersion
- Made the runner mini game more meaningful than a simple collection task
- Improved decision-making pressure without over-complicating controls
- Improved pacing so restocking feels urgent but fair
- Clarified that this refinement phase focuses on the Runner loop rather than a fixed rhythm set

---

## 2026-03-26
**Date:** 2026-03-26  
**Change:** In-game introduction flow and ingredient category structure were finalized.
- Added first-time player introduction flow:
  - Order prompt appears at game start
  - Step-by-step guidance from onboarding to selecting a station
  - Guided onboarding through station interactions
  - Narrative framing of the assistant chef working under the head chef
- Finalized inventory ingredient categories:
  - `Meats`
  - `Vegetables`
  - `DryIngredients`
  - `WetIngredients`
  - `Spices`
- Mapped category usage by section:
  - `Cutting` uses meats/vegetables
  - `Stirring` uses dry/wet/spices
  - `Cooking` consumes prepared outputs from prior sections
  - `Plating` uses final cooked output

**Reason:**  
The game needed clear onboarding and consistent inventory taxonomy so players can understand what each station needs and why.

**Improvements Made:**  
- Improved first-time player comprehension and reduced confusion
- Standardized ingredient handling across kitchen systems
- Better alignment between gameplay logic, UI display, and player decision flow

---

## 2026-03-27
**Date:** 2026-03-27  
**Change:** Submission-day final polish and build verification were completed.
- Performed UI readability pass for onboarding panels and kitchen HUD
- Confirmed no fixed rhythm set in this refinement scope
- Finalized simplified station mechanics for submission:
  - `Cutting`: color game
  - `Stirring`: runner food-run to end of trail
  - `Cooking`: press action button until process reaches 100%
  - `Plating`: display quality and recognition text update
- Finalized recipe count to `4` for stable scope
- Confirmed no dialogue and no story/narrative in final build due to time limits
- Ran inventory and running loop sanity checks
- Verified Runner health behavior during incorrect ingredient collection
- Verified 20% health loss per incorrect ingredient from a starting 100 health
- Verified obstacle interactions (rocks/stones) apply slow/time pressure correctly
- Verified test spawn bounds in market scene:
  - `x`: 233.72 to 253.94
  - `z`: -50.36 to 47.9
  - `y`: 50.2
- Verified flow returns from Runner to kitchen dish completion
- Performed quick build/run verification for PC/Windows target
- Logged known build issues and prepared gameplay video evidence for lecturer review

**Reason:**  
Submission deadline required stability, clarity, and a dependable end-to-end loop.

**Improvements Made:**  
- Reduced last-minute usability issues
- Improved control clarity and first-time play flow
- Increased confidence in submission stability
- Brought project scope in line with what is fully playable and demonstrable

---

## 2026-03-27 (Documentation & Tools Update)
**Date:** 2026-03-27  
**Change:** Project documentation and tool credits were updated to match delivered implementation.
- Updated docs to reflect no narrative/dialogue in final scope
- Updated docs to reflect 4-recipe limit and station-specific mechanics
- Added tooling credits used in development:
  - GitHub Copilot
  - ChatGPT
  - Cursor
  - Mixamo
  - Artlist.io (3 music tracks)
  - AI tools for art and documentation assistance
- Added tools menu support for:
  - title artwork display in menu
  - 3-track music selection and stop control
- Added submission note that video demonstrates systems where build issues remain

**Reason:**  
Documentation needed to accurately represent the final deliverable for academic assessment.

**Improvements Made:**  
- Improved transparency and originality reporting
- Reduced mismatch between documentation and implemented gameplay
- Made lecturer-facing review clearer and more reliable

---

## 2026-03-27 (Final Scope Lock & Submission)
**Date:** 2026-03-27  
**Change:** Final gameplay scope was locked for submission and simplified to a clear, non-time-based flow.
- Added 3 new background music clips (Artlist.io) to support a fun, lighter game tone
- Confirmed runner is now breather gameplay:
  - collect apples
  - avoid obstacles
  - stay alive and reach end of trail
  - return to cooking flow after run
- Confirmed flow state:
  - select dishes to create
  - complete sections
  - plate dish
  - evaluate quality
  - increase recognition from boss chef feedback text
- Confirmed no story/narrative and no dialogue in final submission
- Added usability flow for returning to main menu and exiting game
- Logged known build issues and confirmed video demonstration is used as evidence

**Reason:**  
The project needed a realistic final scope due time constraints and technical issues in the build pipeline.

**Improvements Made:**  
- Made gameplay instructions clearer and easier to follow
- Improved flow from runner section back to cooking progression
- Improved submission readiness through stronger documentation + video proof
- Reduced scope risk while keeping core engagement

---

## How to maintain this log
- Add one new dated entry for each meaningful system or design change.
- Keep every entry in this format: **Date**, **Change**, **Reason**, **Improvements Made**.
- Keep the same Change/Reason/Improvements structure for consistency.
- Update the last entry whenever a new system is added or gameplay is rebalanced.
- Keep language concise and student-friendly so team members can review quickly.
