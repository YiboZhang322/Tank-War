# Game Design Document (GDD)

## Table of Contents
- [Game Overview](#game-overview)
- [Story and Narrative](#story-and-narrative)
- [Gameplay and Mechanics](#gameplay-and-mechanics)
- [Levels and World Design](#levels-and-world-design)
- [Art and Audio](#art-and-audio)
- [User Interface (UI)](#user-interface-ui)
- [Technology and Tools](#technology-and-tools)
- [Team Communication and Task Assignment](#team-communication-and-task-assignment)
- [Possible Challenges](#possible-challenges)

## Game Overview
Core Concept:
Desk Defense is a small-scale 3D shooting game that takes place entirely on a wooden desk inside a cozy room. The idea is simple — you control a miniature cannon sitting on a desk, surrounded by everyday objects like books, tissue boxes, wine bottles, and cups. Your mission is to knock down toy soldier enemies placed around the table while avoiding damage to the surrounding items. The challenge is to aim carefully, control your power, and maximize your score by hitting only the right targets.

Related genres:
Primary Genres: Casual, Shooter, Physics-based
Similar Games: Angry Birds (aim + shoot mechanics), ShellShock Live (angle control), and Toy Soldiers (miniature theme)

Differentiators:
Unlike typical outdoor shooting games, Desk Defense embraces a miniature world — everything around you feels giant, from a wine bottle to a napkin box. The player’s sense of scale gives a playful, toy-like charm. Instead of destroying buildings, you’re trying to hit tiny enemies while protecting the “normal” desk environment.

Target Audience:
This game targets:
Casual players who like quick and relaxing gameplay
Students or office workers looking for a few minutes of stress relief
Players who enjoy physics-based challenges and miniaturized environments

Unique Selling Points (USPs):
Miniature World: Everything feels tiny and playful — you’re fighting battles in a normal room.
Realistic Physics: Objects react naturally when hit — cups might wobble, and toy soldiers tumble over.
Skill-based Aiming: Easy to pick up, but accuracy and precision decide your final score.

## Story and Narrative
Backstory:
There isn’t a deep story here — the fun comes from the imagination. You are a small desk cannon built for “Desk Defense.” The toy soldiers have invaded your workspace, and you must protect your territory by taking them down one by one. Every object around you — from books to bottles — is part of your battleground.

Characters:
Player: The miniature cannon on the desk.
Enemies: Small toy soldiers or figurines that act as moving or static targets.
Neutral Objects: Books, cups, and other items that should be protected from being hit.

## Gameplay and Mechanics

Player Perspective:
Third-person view positioned slightly behind and above the cannon. The camera stays close enough to feel immersive but wide enough to show your surroundings.

Controls:
Left / Right Arrow Keys: Move the cannon horizontally
Up / Down Arrow Keys: Adjust shooting angle
Spacebar: Fire the cannonball

Gameplay Goal:
Knock down all toy enemies while avoiding friendly objects. Damaging neutral items reduces your final score.

Progression:
Each round introduces slightly more complex setups — more obstacles, tighter spaces, and more targets.

Physics System:
Unity’s built-in PhysX handles gravity, collisions, and object movement. Every shot feels satisfying when something tumbles or falls realistically.

## Levels and World Design

Two playable stages have been set up. The first one is the Medium level — it’s mainly about aiming and shooting targets to get comfortable with the cannon controls. The second stage is Hard, where a boss appears and automatically shoots fireballs at the player. User have to move left and right with the arrow keys to dodge its attacks, then find the right timing to strike back and defeat it.

Game World:
All gameplay takes place on a desk inside a small, sunlit room. The surrounding space — chairs, windows, and walls — adds realism without distracting the player.

Objects:
Tissue box
Books
Wine bottles
Cups and glasses
Toy targets and so on

Physics:
Unity PhysX engine handling:
Gravity effects
Collision detection
Realistic object movement and destruction

## Art and Audio

Art Style:
The visual tone is bright, casual, and a little cartoonish — nothing too serious. The room feels cozy, the wood textures are warm, and all the objects are colorful and slightly stylized.

Assets:
Unity Asset Store
Kenney.nl
Freesound.org

## User Interface (UI)

The UI is simple and easy to read:
The bottom-left corner shows the bullet count, and the bottom-right corner shows the score.
When all bullets are used, the game automatically brings up the result screen, displaying the final score.
From there, user can either hit Start Over to replay the same level or choose Next Level to move on to the harder stage.

## Technology and Tools
 
Engine: Unity6
Version Control: GitHub
Project Management: Trello
Additional Tools: Audacity, image editing software

## Team Communication and Task Assignment
English language communication
Discord for daily communication
Trello for task management

## Possible Challenges
Performance Optimization: Managing physics calculations for WebGL
Collision Stability: Small-scale models sometimes behave unpredictably under physics simulation.
Level Design: Creating satisfying destruction scenarios
