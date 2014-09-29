namespace Refrigerator_Management_App
{
    internal class RefrigeratorManager
    {
        private double refrigeratorMaximumWeightHolder;
        private int numberOfUnit;
        private double weightPerUnit;
        private double currentWeight;
        private double remainingWeight;




        public double RefrigeratorMaximumWeightHolder
        {
            set { refrigeratorMaximumWeightHolder = value; }
        }

        public int NumberOfUnit
        {
            set { numberOfUnit = value; }
        }

        public double WeightPerUnit
        {
            set { weightPerUnit = value; }
        }

        public double CurrentWeight
        {
            get { return numberOfUnit*weightPerUnit; }
        }

        public double RemainingWeight
        {
            get { return refrigeratorMaximumWeightHolder-(numberOfUnit*weightPerUnit); }
        }
    }
}