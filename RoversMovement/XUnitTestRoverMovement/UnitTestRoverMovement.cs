using System;
using Xunit;
using Models;
using RoversMovement;

namespace XUnitTestRoverMovement
{
    public class UnitTestRoverMovement
    {
        [Fact]
        public void FinalPosition_Position1_MovementSignals1_ReturnSuccess()
        {
            var roverCurrentPosition = new RoverPosition() { Plateau = "5 5", Position = "1 2 N", MovementSignals = "LMLMLMLMM" };
            IRoverMovementService roverMovement = new RoverMovementService();
            Assert.Equal("1 3 N", roverMovement.RoverMovement(roverCurrentPosition));
        }

        [Fact]
        public void FinalPosition_Position2_MovementSignals2_ReturnSuccess()
        {
            var roverCurrentPosition = new RoverPosition() { Plateau = "5 5", Position = "3 3 E", MovementSignals = "MMRMMRMRRM" };
            IRoverMovementService roverMovement = new RoverMovementService();
            Assert.Equal("5 1 E", roverMovement.RoverMovement(roverCurrentPosition));
        }

        [Fact]
        public void FinalPosition_Position3_MovementSignals3_ReturnSuccess()
        {
            var roverCurrentPosition = new RoverPosition() { Plateau = "5 5", Position = "2 3 W", MovementSignals = "MMLMMLMM" };
            IRoverMovementService roverMovement = new RoverMovementService();
            Assert.Equal("2 1 E", roverMovement.RoverMovement(roverCurrentPosition));
        }
    }
}
