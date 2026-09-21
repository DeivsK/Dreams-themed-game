# Dream/Nightmare — Progressive Level Transformation

A 3D platformer prototype built in Unity for a course project themed around "dreams." 
The level gradually shifts from a light dreamscape into a more dangerous nightmare state 
as the player collects items, with previously safe areas becoming hazardous once 
enough progress is made.

## Core Concept
Collectibles act as progression triggers rather than just score — each one gathered 
pushes the level state further toward its "nightmare" form. Hazards that once existed 
only as a warning become active and dangerous, and the environment itself darkens to 
reflect the shift.

## Core Features
- Progressive level-state system tied to collectible count
- Escalating hazard states (dormant → warning → active/dangerous)
- Environmental tone shift (color/lighting) reflecting dream-to-nightmare progression
- Basic humanoid character controller with movement and jump

## Status
Built solo as a timed course project — an early exploration of the concept with 
limited time for visual execution. The environmental transformation is currently 
represented through color/lighting shifts rather than full asset changes; mechanics 
and level-state logic are functional and tested.

## Tech
Unity, C#
