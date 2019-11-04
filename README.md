# RoversFinalLocation
Move the Rover based on provided signals

Project has been implemented with .Net core 2.0

Solution has 3 projects named
1. RoversMovement
2. Models
3. XUnitTestRoverMovement

Created 3 unit test cases with below inputs for success scenarios

1. 
    I/P -> Plateau = "5 5", Position = "1 2 N", MovementSignals = "LMLMLMLMM" 
    O/P -> 1 3 N
2.
    I/P -> Plateau = "5 5", Position = "3 3 E", MovementSignals = "MMRMMRMRRM"
    O/P -> 5 1 E
3.
    I/P -> Plateau = "5 5", Position = "2 3 W", MovementSignals = "MMLMMLMM"
    O/P -> 2 1 E
