namespace Ch06
{
    class Program
    {
        public enum Planets
        {
            Sun = 0,       	 /*  Otherwise compiler will assign default value */
            Mercury,        	 /*  C# compiler will assign 1 */
            Venus,          	 /*  C# compiler will assign 2 */
            Earth,          	 /*  C# compiler will assign 3 */
            Mars,           	 /*  C# compiler will assign 4 */
            Jupiter,        	 /*  C# compiler will assign 5 */
            Saturn,         	 /*  C# compiler will assign 6 */
            Uranus,         	 /*  C# compiler will assign 7 */
            Neptune         	 /*  C# compiler will assign 8 */
        }

        static void Main(string[] args)
        {
            Planets planets = new Planets();
            planets = Planets.Earth;
        }
    }
}
