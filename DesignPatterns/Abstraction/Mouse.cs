namespace Abstraction
{
    public class Mouse
    {
        private bool IsPluggedIn;
        private int currXPos;
        private int currYPos;

        public Mouse()
        {
            IsPluggedIn = true;
        }

        public void Move(int xOffset, int yOffset)
        {
            if (IsPluggedIn)
            {
                currXPos += xOffset;
                currYPos += yOffset;
            }
        }
    }
}