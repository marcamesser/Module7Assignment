namespace Module7Assignment
{
    public class Coffee
    {
        private int strength;
        private string bean;
        private string countryOfOrigin;

        public Coffee(int strength, string bean, string countryOfOrigin)
        {
            this.strength = strength;
            this.bean = bean;
            this.countryOfOrigin = countryOfOrigin;
        }

        public int Strength
        {
            get => strength;
            set => strength = value;
        }

        public string Bean
        {
            get => bean;
            set => bean = value;
        }

        public string CountryOfOrigin
        {
            get => countryOfOrigin;
            set => countryOfOrigin = value;
        }
    }
}