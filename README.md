# Documentation for CG Program

## Overview
The `CG` program is a simple console-based movement simulator where a character (represented as a string) moves across the console screen. The program allows movement using the `WASD` or arrow keys, with additional controls for clearing, saving, loading, and "killing" the character.

## Namespace and Class Structure
- **Namespace:** `CG`
- **Class:** `Program`
- **Accessibility:** `internal`
- **Main Entry Point:** `Main` method

## Global Variables
- `charc` (string): Represents the character's current state and position.
- `CanMove` (bool): Determines if movement is allowed.
- `IsAlive` (bool): Tracks whether the character is alive.
- `FirstMove` (bool): Ensures initialization runs only once.

## Methods
### `Main(string[] args)`
#### Purpose:
- Sets up initial console colors.
- Displays movement instructions on first run.
- Initializes the `charc` variable.
- Calls the `Move()` method to handle user input.

#### Logic Flow:
1. If `IsAlive` is `true`, sets the console background to dark green and text to white.
2. If `FirstMove` is `true`, clears the console, prints instructions, and initializes `charc` as `":3"`.
3. Calls `Move()` to start handling user input.

---
### `Move()`
#### Purpose:
- Handles user input and modifies `charc` accordingly.
- Supports movement, saving, loading, clearing, and "killing" the character.

#### User Controls:
| Key         | Action                     |
|------------|---------------------------|
| `D` / `RightArrow`  | Move right |
| `A` / `LeftArrow`  | Move left |
| `S` / `DownArrow`  | Move down |
| `W` / `UpArrow`  | Move up |
| `Delete` | Reset character |
| `Escape` | Kill character |
| `L` | Load last saved state |
| `Enter` | Save current state |

#### Behavior:
- Checks if movement is allowed (`CanMove` and `IsAlive` are `true`).
- Adjusts `charc` based on input.
- Clears the console and prints `charc` after each input.
- Calls `Main(null)` to keep the loop running.

---
### `MCKill()`
#### Purpose:
- Changes `IsAlive` to `false`.
- Replaces `":3"` with `"X_X"` to indicate death.
- Sets console background to dark red and text to black.

## File Handling
- **Save (`Enter` key)**: Writes `charc` to `GameData/Last.dat`.
- **Load (`L` key)**: Reads `charc` from `GameData/Last.dat`.

## Summary
This program allows a user to interact with a console-based character using simple keyboard inputs. The character can move, reset, save/load state, and "die." The logic is structured in a recursive manner to keep the game running indefinitely.
