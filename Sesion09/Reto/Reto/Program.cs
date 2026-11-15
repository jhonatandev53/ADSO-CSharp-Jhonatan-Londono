namespace Reto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FormPin formPin = new FormPin();

           
            if (formPin.ShowDialog() == DialogResult.OK)
            {
                
                Application.Run(new Form1());
            }
            else
            {
                
                Application.Exit();
            }
        }
    }
}