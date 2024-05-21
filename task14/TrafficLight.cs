namespace task14
{
    internal class TrafficLight
    {
        public Color TrafficLightColor { get; set; }
        public TrafficLight(Color color)
        {
            TrafficLightColor = color;
        }
        public enum Color : int
        {
            Red,
            Yellow,
            Green
        }
        public void ChangeColor()
        {
            switch (TrafficLightColor)
            {
                case Color.Red:
                    TrafficLightColor = Color.Green;
                    break;
                case Color.Green:
                    TrafficLightColor = Color.Yellow;
                    break;
                case Color.Yellow:
                    TrafficLightColor = Color.Red;
                    break;
            }
        }
        public Color GetColor()
        {
            return TrafficLightColor;
        }
    }
}
