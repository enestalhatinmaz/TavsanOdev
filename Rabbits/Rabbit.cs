

namespace Rabbits
{
    class Rabbit
    {
        public int Coordinate { get; set; }
        public int JumpDistance { get; set; }

        public void Jump()
        {
            Coordinate += JumpDistance;
        }

        public Rabbit(int startP, int Distance)
        {
            Coordinate = startP;
            JumpDistance = Distance;

        }
    }
}
